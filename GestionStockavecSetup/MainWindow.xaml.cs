using AutoMapper;
using GestionStock.Controller;
using GestionStock.Data;
using GestionStock.Data.Services;
using GestionStock.Windows;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestionStock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MyDbContext _context { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            ConnexionBDD();
            //var context = new MyDbContext();
            //var service = new ArticleServices(context);
            //dgListe.ItemsSource = service.GetAllArticles();
            //var controller = new ArticleController(context);
            //dgListe.ItemsSource = controller.GetAllArticles();
        }

        private void BtnGestionArticle_Click(object sender,RoutedEventArgs e)
        {
            string param = "Gestion Articles";
            this.Opacity = 0.5;
            GestionArticles win = new GestionArticles(param, this,_context);
            win.ShowDialog();
            this.Opacity = 1;
        }

        private void Btn(object sender, RoutedEventArgs e)
        {

        }

        private void ConnexionBDD()
        {
            try
            {
                StreamReader FILE = new StreamReader("../../../connexion.json");
                string chaine = FILE.ReadToEnd();
                DatabaseConnection connection = JsonConvert.DeserializeObject<DatabaseConnection>(chaine);
                _context = new(connection);
            }
            catch (FileNotFoundException e)
            {
                Trace.Write(e.Message);
            }
        }
    }
}
