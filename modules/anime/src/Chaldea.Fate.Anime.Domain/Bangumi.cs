using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Chaldea.Fate.Anime
{
    public class Bangumi : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public ICollection<Guid> Animes { get; set; }
    }
}