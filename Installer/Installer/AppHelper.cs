using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Installer
{
    public static class AppHelper
    {
        public static bool Save(string server, string database, string userbase, string password)
        {
            if (File.Exists(@"D:\Test.txt"))
                File.Delete(@"D:\Test.txt");
            File.WriteAllText(@"D:\Test.txt", $"Server={server}, Database={database},Userbase={userbase},Password={password}"); 
            return true;
        }
    }
}
