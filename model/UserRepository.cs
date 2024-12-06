using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livrable.model
{
    public class UserRepository
    {
        private List<User> _users = new List<User>();
        public void addUser(User user)
        {
            _users.Add(user);
        }
        public User getUser(string name,string password) {
            return _users.Find(user => user.Name==name && user.Password==password);
        }
        public Boolean isUser(string name, string password)
        {
           return getUser(name, password) != null;
        }

    }
}
