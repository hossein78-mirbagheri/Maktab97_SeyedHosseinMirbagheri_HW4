using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Threading.Channels;

namespace HW4
{
    public class CreateUsers
    {
        string path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName + "\\FileDataStorage.csv";
     
        public bool AddUser(string Name, long Mobile, DateTime BirthDate)
        {
           string date = string.Empty;
           date = BirthDate.ToString("dd/MM/yyyy");
           User user = new User();
            user.Name = Name;
            user.Mobile = Mobile;
            user.BirthDate = BirthDate;
            var jsonfile = JsonConvert.SerializeObject(user);
            File.AppendAllText(path, jsonfile + Environment.NewLine);
            return true;
        }
        public void DeleteUser(string Name) 
        {
            
        }
        public void ShowUser()
        {
            //int i = 0;
            //foreach (var user in DataStorage.bookList)
            //{
            //    i++;
            //    Console.WriteLine($"book number{i} is :{book.Title}");
            //}
            //Console.WriteLine();
        }
    }
}
