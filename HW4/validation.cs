using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public class validation
    {
        
        
            string? path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName + "\\FileDataStorage.csv";
            public bool newUser(long phonenumber, DateTime birthday)
            {
                if (phonenumber > 12 || phonenumber < 10)
                {
                    throw new MobileException("not valid Mobile");
                }
                if (birthday < DateTime.Now)
                {
                    throw new BirthDayException("you dont born yet");
                }
                return true;
            }
            public bool updata(int id)
            {
                var jsonId = File.ReadAllLines(path);
                foreach (var line in jsonId)
                {
                    var specficId = JsonConvert.DeserializeObject<User>(line);
                    if (specficId.id != id)
                    {
                        throw new UpDataException("not user found");
                    }
                }
                return true;
            }
    }
}
