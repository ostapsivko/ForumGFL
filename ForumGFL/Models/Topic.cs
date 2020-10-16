using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumGFL.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string TopicBody { get; set; } = "";
        public string Author { get; set; } = "";
        public int MessageCount { get; set; } = 1;
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastUpdated { get; set; } = DateTime.Now;
        //public List<ForumMessage> Messages { get; set; }
    }
}
