using GestionStock.Controller;
using GestionStock.Data;
using GestionStock.Data.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using static GestionStock.Data.Dtos.ArticleDTO;

namespace GestionStock.Windows
{
    /// <summary>
    /// Logique d'interaction pour FormAjoutProduit.xaml
    /// </summary>
    public partial class FormAjoutProduit : Window
    {
       
        public string Param { get; set; }
        private MyDbContext _context;
        private CategorieController _controller;
        private ArticleController _controllerArticle;
        public FormAjoutProduit(string param)
        {
            this.Param = param;
            InitializeComponent();
            _context = new MyDbContext();
            _controller = new CategorieController(_context);
            _controllerArticle = new ArticleController(_context);
            InitComboboxCategories();  
        }

        // Initialisation de la comboBox Catégories avec la table categories
        private void InitComboboxCategories()
        {
            categorie.ItemsSource = _controller.GetAllCategories();
            categorie.DisplayMemberPath = "LibelleCategorie";
            categorie.SelectedValuePath = "IdCategorie";
        }

        private void BtnRetour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnEnregistrer_Click(object sender, RoutedEventArgs e)

        {
            var newArticle = new ArticleDTOIn();
            newArticle.LibelleArticle = libelleArticle.Text;
            newArticle.QuantiteStockee = Convert.ToInt32(quantite.Text);
            newArticle.IdCategorie = (int)categorie.SelectedValue;
            _controllerArticle.CreateArticle(newArticle);
            this.Close();
        }

        //private void categorie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    ComboBox cmb = (ComboBox)sender;
        //    Trace.WriteLine(cmb.SelectedValue);
        //    Trace.WriteLine(cmb.SelectedValuePath);
        //   
        //}
    }

}
