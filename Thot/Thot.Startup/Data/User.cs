using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thot.Startup.Data
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User GetUser()
        {
            User user = new User();

            //Implementa uma busca no banco de dados e atribui à variavel user.

            return user;
        }
    }
}
