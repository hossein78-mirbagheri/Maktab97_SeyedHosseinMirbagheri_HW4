using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public class ShowUser
    {
       public string[] showlist(string path)
        {
            int i = 0;
            var d = File.ReadAllLines(path);
            string[] lines = new string[d.Length];
            foreach(string line in d) 
            {
                lines[i] = line;
                i++;
            }
            if(d.Length == 0)
            {
                return null;
            }
            return lines;
        }
    }
}
