﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    [RunInstaller(true)]
    public partial class Installer2 : System.Configuration.Install.Installer
    {
        public Installer2()
        {
            InitializeComponent();
        }

        public override void Install(IDictionary stateSaver)
        {
            /*List<string> liste = new List<string>();
            string DatabaseName = "test";
            base.Install(stateSaver);
            DatabaseName = this.Context.Parameters["databaseName"];
            Console.WriteLine(DatabaseName + "************************");
            liste.Add(DatabaseName);
            File.WriteAllLines("C:/Users/1701871/Desktop/Test.txt", liste);*/
        }
    }
}
