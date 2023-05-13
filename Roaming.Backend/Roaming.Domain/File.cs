using System;

namespace Roaming.Domain
{
    public class File
    {
        public int Id { get; set; }
        public Guid DocumentId { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public byte[] Sign { get; set; }
        public string Type { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public Document Document { get; set; }
    }
}
