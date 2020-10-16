using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumGFL.Models
{
    public class ForumMessage
    {
        public int Id { get; set; }
        public int TopicId { get; set; }
        public string MessageBody { get; set; } = "";
        public string Author { get; set; } = "";
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastUpdated { get; set; } = DateTime.Now;

    }
}
