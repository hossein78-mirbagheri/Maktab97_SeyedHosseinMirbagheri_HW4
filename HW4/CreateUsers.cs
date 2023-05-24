using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Threading.Channels;

namespace HW4
{
    public class CreateUsers
    {
        string path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName + "\\FileDataStorage.csv";
        int finalid = 1;
        public bool AddUser(string Name, long Mobile, DateTime BirthDate)
        {
           string date = string.Empty;
           date = BirthDate.ToString("dd/MM/yyyy");
           User user = new User();
            user.id = newid(finalid);
            user.Name = Name;
            user.Mobile = Mobile;
            user.BirthDate = BirthDate;
            user.Time = DateTime.Now.ToString();
            var jsonfile = JsonConvert.SerializeObject(user);
            File.AppendAllText(path, jsonfile + Environment.NewLine);
            return true;
        }
        public int newid(int Id)
        {
            int fixid;
            var pathLins = File.ReadAllLines(path);
            foreach (string specificLine in pathLins)
            {
                var fileToJson = JsonConvert.DeserializeObject<User>(specificLine);
                if (specificLine == "")
                {
                    return Id;
                }
                else if (fileToJson.id == Id)
                {
                    Id++;
                }
            }
            foreach (string specificLine in pathLins)
            {
                var fileToJson = JsonConvert.DeserializeObject<User>(specificLine);
                if (Id == fileToJson.id)
                {
                    Id++;
                }
            }
            return Id;
        }

        public void DeleteUser(string Name) 
        {
            
        }
       
    }
}
