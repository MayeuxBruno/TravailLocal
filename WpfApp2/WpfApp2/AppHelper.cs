using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public static class AppHelper
    {
        public static bool Save(string database)
        {
            File.WriteAllText(@"D:\Test.txt", $"Database={database}");
            return true;
        }
    }
}
