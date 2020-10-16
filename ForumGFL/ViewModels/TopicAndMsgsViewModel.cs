using ForumGFL.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumGFL.ViewModels
{
    public class TopicAndMsgsViewModel
    {
        public Topic Topic { get; set; }
        public List<ForumMessage> Messages { get; set; }
        public ForumMessage Message { get; set; }
        public HttpContext context { get; set; }
    }
}
