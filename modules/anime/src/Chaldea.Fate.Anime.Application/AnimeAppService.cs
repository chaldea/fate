using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Chaldea.Fate.Anime.Localization;
using HtmlAgilityPack;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.BlobStoring;
using Volo.Abp.Domain.Repositories;

namespace Chaldea.Fate.Anime
{
    public class AnimeAppService : ApplicationService
    {
        private readonly IRepository<Anime, Guid> _animeRepository;
        private readonly IRepository<Bangumi, Guid> _bangumiRepository;
        private readonly IBlobContainer _blobContainer;

        protected AnimeAppService(
            IRepository<Anime, Guid> animeRepository, 
            IRepository<Bangumi, Guid> bangumiRepository,
            IBlobContainer blobContainer)
        {
            _animeRepository = animeRepository;
            _bangumiRepository = bangumiRepository;
            _blobContainer = blobContainer;
            LocalizationResource = typeof(AnimeResource);
        }

        public async Task ImportAsync(ImportDto dto)
        {
            Bangumi bangumi = null;
            if (!dto.BangumiId.HasValue)
            {
                bangumi = await _bangumiRepository.FirstOrDefaultAsync(x => x.Id == dto.BangumiId.Value);
            }
            
            var animeList = new List<Anime>();
            var web = new HtmlWeb();
            var client = new HttpClient();
            var baseUrl = new Uri(dto.Url).GetLeftPart(UriPartial.Authority);
            var animeListPage = web.Load(dto.Url);
            var animeListNodes = animeListPage.DocumentNode.SelectNodes("//div[@class='zt-dh adj2']/ul/li/p/a/img");
            var animeDetailUrls = new Dictionary<string, string>();
            foreach (var animeListNode in animeListNodes)
            {
                var href = animeListNode.ParentNode.Attributes["href"].Value;
                animeDetailUrls.TryAdd(href, $"{baseUrl}{href}");
            }

            foreach (var animeDetailUrl in animeDetailUrls)
            {
                var animeDetailPage = web.Load(animeDetailUrl.Value);
                // title
                var title = animeDetailPage.DocumentNode.SelectSingleNode("//div[@class='anime-img']/h1").InnerText
                    .Trim();

                // image
                var imgUrl = animeDetailPage.DocumentNode.SelectSingleNode("//div[@class='anime-img']/img")
                    .Attributes["src"].Value;

                var downloadUrl = imgUrl.Substring(0, 4).ToLower() == "http" ? imgUrl : $"{baseUrl}{imgUrl}";
                var imgName = Path.GetFileName(imgUrl);
                if (imgName.Contains("?"))
                {
                    imgName = imgName.Substring(0, imgName.IndexOf("?", StringComparison.Ordinal));
                }

                await using var stream = await client.GetStreamAsync(downloadUrl);
                await _blobContainer.SaveAsync(imgName, stream);
                // _blobContainer.SaveAsync("",)

                // var savePath = Path.Combine(imgPath, imgName);
                // if (!System.IO.File.Exists(savePath))
                //     webClient.DownloadFile(downloadUrl, savePath);

                // desc
                string desc;
                var node = animeDetailPage
                    .DocumentNode.SelectSingleNode("//div[@id='box']/span[@id='showall']");
                if (node == null)
                {
                    node = animeDetailPage
                        .DocumentNode.SelectSingleNode("//div[@id='box']");
                    desc = node.InnerText.Trim();
                }
                else
                {
                    desc = node.InnerText.Trim();
                }

                var anime = new Anime
                {
                    Title = title,
                    Cover = imgName,
                    Desc = desc
                };
                animeList.Add(anime);
                bangumi?.Animes.Add(anime.Id);
            }

            await _animeRepository.InsertManyAsync(animeList);

            if (bangumi != null)
            {
                await _bangumiRepository.UpdateAsync(bangumi);
            }
        }

        public async Task<PagedResultDto<AnimeDto>> PagedList(PagedListDto dto)
        {
            var animes = await _animeRepository.GetPagedListAsync(dto.SkipCount, dto.MaxResultCount, dto.Sorting);
            var total = await _animeRepository.GetCountAsync();
            var data = ObjectMapper.Map<List<Anime>, List<AnimeDto>>(animes);
            return new PagedResultDto<AnimeDto>(total, data);
        }
    }
}
