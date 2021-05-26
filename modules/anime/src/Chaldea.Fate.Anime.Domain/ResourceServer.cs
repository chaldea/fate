using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Chaldea.Fate.Anime
{
    public class Server
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class ResourceServer : FullAuditedAggregateRoot<Guid>
    {
        public List<Server> Servers { get; set; }
    }
}