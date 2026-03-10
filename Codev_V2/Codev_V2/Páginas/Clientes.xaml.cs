using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Codev_V2.Páginas
{
    /// <summary>
    /// Interação lógica para Clientes.xam
    /// </summary>
    public partial class Clientes : Page
    {
        public Clientes()
        {
            InitializeComponent();
        }
        public class ListClientes()
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Modelo { get; set; }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var clientes = new List<ListClientes>
            {
                new ListClientes{Id = 1, Nome="Adrian Oliveira", Modelo="Galaxy S23 FE",
                },
                 new ListClientes{Id = 3, Nome="Maria Joana", Modelo="iPhone 14 Pro Max",
                },
                  new ListClientes{Id = 44, Nome="Irineu da Silva", Modelo="Samsung Pocket",
                },
                   new ListClientes{Id = 33, Nome="Jalin Rabei", Modelo="Windows Phone",
                },
            };
            CodevClientes.ItemsSource = clientes;
        }
    }
}
