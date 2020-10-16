using ForumGFL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumGFL.Data.RepositoryOfTopics
{
    public interface IRepositoryOfTopics
    {
        Topic GetTopic(int id);
        List<Topic> GetAllTopics();
        void AddTopic(Topic topic);
        void UpdateTopic(Topic topic);
        void RemoveTopic(int id);
        Task<bool> SaveChangesAsync();

    }
}
