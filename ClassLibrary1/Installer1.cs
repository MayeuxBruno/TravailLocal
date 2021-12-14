using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary1
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
            string server = this.Context.Parameters["server"];
            string database = this.Context.Parameters["database"];
            string ssl = this.Context.Parameters["ssl"];
            string user = this.Context.Parameters["user"];
            string port = this.Context.Parameters["port"];
            string password = this.Context.Parameters["password"];
            File.WriteAllText("..\\GestionCantine\\test.txt",server+"-"+database+"-"+ssl+"-"+user+"-"+port+"-"+password);
        }
    }
}
