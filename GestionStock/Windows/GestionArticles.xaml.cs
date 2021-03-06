using GestionStock.Controller;
using GestionStock.Data;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace GestionStock.Windows
{
    /// <summary>
    /// Logique d'interaction pour GestionArticles.xaml
    /// </summary>
    public partial class GestionArticles : Window
    {
        MainWindow Fenetre;
        private readonly ArticleController _controller;
        private readonly MyDbContext _context;
        public string Param { get; set; }
        public GestionArticles(string param, MainWindow fenetre)
        {
            this.Param = param;
            this.Fenetre = fenetre;
            InitializeComponent();
            _context = new MyDbContext();
            _controller = new ArticleController(_context);
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            dgListeArticle.ItemsSource = _controller.GetAllArticles();
        }
        private void BtnAnnule_Click(object sender,RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnAjout_Click(object sender, RoutedEventArgs e)
        {
            string param = "Ajouter";
            this.Opacity = 0.5;
            FormAjoutProduit win = new FormAjoutProduit(param);
            win.ShowDialog();
            this.Opacity = 1;
            LoadDataGrid();
        }

     

      

        private void dgListeArticle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
           
        }
    }
}
