using ForumGFL.Data.RepositoryOfMessages;
using ForumGFL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumGFL.Data.RepositoryOfTopics
{
    public class RepositoryOfMessages : IRepositoryOfMessages
    {
        private ForumDBContext _context;
        public RepositoryOfMessages(ForumDBContext context)
        {
            _context = context;
        }

        public List<ForumMessage> GetMessages(int id)
        {
            List<ForumMessage> messages = new List<ForumMessage>();
            messages = _context.ForumMessage.ToList().FindAll(c => c.TopicId == id);
            return messages;
        }

        public ForumMessage GetMessage(int id)
        {
            return _context.ForumMessage.FirstOrDefault(m => m.Id == id);
        }
        public void AddMessage(ForumMessage message)
        {
            _context.ForumMessage.Add(message);            
        }
        public void UpdateMessage(ForumMessage message)
        {
            _context.ForumMessage.Update(message);
        }

        public void RemoveMessage(int id)
        {
            _context.ForumMessage.Remove(GetMessage(id));
        }

        public async Task<bool> SaveChangesAsync()
        {
            if (await _context.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }
    }
}
