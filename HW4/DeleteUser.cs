using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public class DeleteUser
    {
        string path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName + "\\FileDataStorage.csv";
        public bool delete(int id)
        {
            int i = 0;
            var readFile = File.ReadAllLines(path);
            StreamWriter w = new StreamWriter(path);
            w.Close();
            foreach (var line in readFile)
            {
                var search = JsonConvert.DeserializeObject<User>(line);
                if (search.id == id)
                {
                    continue;
                }
                var final = JsonConvert.SerializeObject(search);
                File.AppendAllText(path, final + Environment.NewLine);
            }
            return true;
        }
    }
}
