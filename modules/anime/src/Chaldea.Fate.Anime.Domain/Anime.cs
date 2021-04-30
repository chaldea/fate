using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Chaldea.Fate.Anime
{
    public class Anime : FullAuditedAggregateRoot<Guid>
    {
        public string Title { get; set; }

        public string Cover { get; set; }

        public string Desc { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public string Director { get; set; }

        public string State { get; set; }

        public string Type { get; set; }

        public int Rating { get; set; }

        public List<string> Tags { get; set; }
    }
}