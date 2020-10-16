using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumGFL.Data.RepositoryOfMessages;
using ForumGFL.Data.RepositoryOfTopics;
using ForumGFL.Models;
using ForumGFL.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ForumGFL.Controllers
{
    public class TopicController : Controller
    {

        private readonly IRepositoryOfTopics _topicRepo;
        private readonly IRepositoryOfMessages _msgRepo;
        private readonly UserManager<IdentityUser> _userManager;

        public TopicController(IRepositoryOfTopics topicRepo, IRepositoryOfMessages msgRepo, UserManager<IdentityUser> userManager)
        {
            _topicRepo = topicRepo;
            _msgRepo = msgRepo;
            _userManager = userManager;
    }

        public IActionResult ShowTopic(int id)
        {
            var topic = _topicRepo.GetTopic(id);
            List<ForumMessage> msgs = _msgRepo.GetMessages(id);
            TopicAndMsgsViewModel tmvm = new TopicAndMsgsViewModel();
            tmvm.Topic = topic;
            tmvm.Messages = msgs;
            tmvm.context = HttpContext;
            return View(tmvm);
        }

        public async Task<IActionResult> RemoveTopic(int id)
        {
            _topicRepo.RemoveTopic(id);
            await _topicRepo.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> CreateTopic(Topic topic)
        {
            topic.Author = HttpContext.User.Identity.Name;
            _topicRepo.AddTopic(topic);
            if (await _topicRepo.SaveChangesAsync())
                return RedirectToAction("Index", "Home");
            else return View(new TopicAndMsgsViewModel());
        }
        [HttpGet]
        public IActionResult CreateTopic()
        {
            return View(new TopicAndMsgsViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(ForumMessage message, int id)
        {
            message.TopicId = id;
            message.Author = HttpContext.User.Identity.Name;
            _msgRepo.AddMessage(message);
            if (await _msgRepo.SaveChangesAsync())
                return RedirectToAction("ShowTopic", new { ID = id }) ;
            else return View(new TopicAndMsgsViewModel());
        }

        [HttpGet]
        public IActionResult CreateMessage(int id)
        {
            return View(new TopicAndMsgsViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> EditMessage(ForumMessage message, int id)
        {
            message.Id = id;
            message.LastUpdated = DateTime.Now;
            _msgRepo.UpdateMessage(message);
            if (await _msgRepo.SaveChangesAsync())
                return RedirectToAction("EditMessage", new { ID = id });
            else return View(new TopicAndMsgsViewModel());
        }

        [HttpGet]
        public IActionResult EditMessage(int id)
        {
            var msg = _msgRepo.GetMessage(id);
            TopicAndMsgsViewModel tmvm = new TopicAndMsgsViewModel();
            tmvm.Message = msg;
            return View(tmvm);
        }

    }
}
