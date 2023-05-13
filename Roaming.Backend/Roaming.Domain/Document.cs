using System;
using System.Collections.Generic;

namespace Roaming.Domain
{
    public class Document
    {
        public Guid Id { get; set; }
        public Guid SenderId { get; set; }
        public Guid RecipientId { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public Counterparty Recipient { get; set; }
        public Counterparty Sender { get; set; }
        public List<File> Files { get; set; } = new List<File>();
    }
}
