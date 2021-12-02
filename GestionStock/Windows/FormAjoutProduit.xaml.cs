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
    /// Logique d'interaction pour FormAjoutProduit.xaml
    /// </summary>
    public partial class FormAjoutProduit : Window
    {
       
        public string Param { get; set; }
        private MyDbContext _context;
        private CategorieController _controller;
        public FormAjoutProduit(string param)
        {
            this.Param = param;
            InitializeComponent();
            _context = new MyDbContext();
            _controller = new CategorieController(_context);
            var liste = _controller.GetAllCategories();

            foreach (var item in liste)
            {
                categorie.Items.Add(new { Text = item.LibelleCategorie, Value = item.IdCategorie });
            }
        }
        private void InitCombobox()
        {
            var liste = _controller.GetAllCategories();
            
        }
        private void BtnRetour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}
