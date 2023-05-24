using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public class MobileException:Exception
    {
        public MobileException(string message)
            : base(message) {}
    }
}
