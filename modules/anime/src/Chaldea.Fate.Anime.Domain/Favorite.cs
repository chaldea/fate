using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Chaldea.Fate.Anime
{
    public class Favorite : FullAuditedAggregateRoot<Guid>
    {
        public Guid? AnimeId { get; set; }
    }
}