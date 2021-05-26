using System;
using System.Threading.Tasks;

namespace Chaldea.Fate.Anime
{
    public class ImportDto
    {
        public string ImportType { get; set; }
        public string Url { get; set; }
        public Guid? BangumiId { get; set; }
    }

    public interface IAnimeAppService
    {
        Task ImportAsync(ImportDto dto);
    }
}
