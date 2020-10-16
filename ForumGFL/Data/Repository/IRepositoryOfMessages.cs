using ForumGFL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumGFL.Data.RepositoryOfMessages
{
    public interface IRepositoryOfMessages
    {
        ForumMessage GetMessage(int id);
        List<ForumMessage> GetMessages(int id);
        void AddMessage(ForumMessage message);
        void UpdateMessage(ForumMessage message);
        void RemoveMessage(int id);
        Task<bool> SaveChangesAsync();

    }
}
