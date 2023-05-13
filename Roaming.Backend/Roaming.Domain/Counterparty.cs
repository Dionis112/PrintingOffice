using System;
using System.Collections.Generic;

namespace Roaming.Domain
{
    public class Counterparty
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime CreationDate { get; set; }
        public List<Document> SenderDocuments { get; set; } = new List<Document>();
        public List<Document> RecipientDocuments { get; set; } = new List<Document>();
        public List<Partnership> FirstPartnerships { get; set; } = new List<Partnership>();
        public List<Partnership> SecondPartnerships { get; set; } = new List<Partnership>();

    }
}
