using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garuchava_Mazurenko_Bakery.ClassHelper
{
    public static class EFClass
    {
        public static DB.Entities1 ContextDB { get; } = new DB.Entities1();
    }
}
