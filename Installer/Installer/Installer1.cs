using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace Installer
{
    [RunInstaller(true)]
    public partial class Installer1 : System.Configuration.Install.Installer
    {
        public Installer1()
        {
            InitializeComponent();
        }

        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);
            string server = Context.Parameters["Server"];
            string database = Context.Parameters["Database"];
            string username = Context.Parameters["Username"];
            string password = Context.Parameters["Password"];
            bool check = AppHelper.Save(server, database, username, password);
            if(!check)
            {
                throw new Exception("Impossible de sauvegarder dans le fichier !!! ");
            }
        }
    }
}
