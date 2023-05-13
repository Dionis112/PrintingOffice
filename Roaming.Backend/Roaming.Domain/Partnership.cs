using System;

namespace Roaming.Domain
{
    public class Partnership
    {
        public int Id { get; set; }
        public Guid CounterpartyFirstId { get; set; }
        public Guid CounterpartySecondId { get; set; }
        public string Status { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public Counterparty FirstCounterparty { get; set; }
        public Counterparty SecondCounterparty { get; set; }
    }
}
