using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public class UpdateUser
    {
        string path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName + "\\FileDataStorage.csv";
        public bool updateuser(int id,string Name, DateTime BirthDate , long Mobile)
        {
            DeleteUser deleteUser1 = new DeleteUser();
            deleteUser1.delete(id);
            CreateUsers createUsers1 = new CreateUsers();
            createUsers1.AddUser(Name,Mobile,BirthDate);
            return true;
        }
    }
}
