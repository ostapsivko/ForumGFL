using ForumGFL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumGFL.Data.RepositoryOfTopics
{
    public class RepositoryOfTopics : IRepositoryOfTopics
    {
        private ForumDBContext _context;
        public RepositoryOfTopics(ForumDBContext context)
        {
            _context = context;
        }

        public Topic GetTopic(int id)
        {
            return _context.Topics.FirstOrDefault(t => t.Id == id);
        }
        public List<Topic> GetAllTopics()
        {
            return _context.Topics.ToList();
        }
        public void AddTopic(Topic topic)
        {
            _context.Topics.Add(topic);            
        }
        public void UpdateTopic(Topic topic)
        {
            _context.Topics.Update(topic);
        }

        public void RemoveTopic(int id)
        {
            _context.Topics.Remove(GetTopic(id));
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
