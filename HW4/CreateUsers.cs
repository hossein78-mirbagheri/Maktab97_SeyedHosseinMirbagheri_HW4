using System.Threading.Channels;

namespace HW4
{
    public class CreateUsers : User
    {
        public void AddUser(string Name, int Mobile, int BirthDate)
        {
            User user = new User()
            {
                Name = Name,
                Mobile = Mobile,
                BirthDate = BirthDate,
            };
            Console.WriteLine("Add User Successfully");
        }
        
    }
}
