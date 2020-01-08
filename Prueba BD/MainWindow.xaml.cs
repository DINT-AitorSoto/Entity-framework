using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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

namespace Prueba_BD
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SQL_Database_AitorEntities context;
        public MainWindow()
        {
            InitializeComponent();
            context = new SQL_Database_AitorEntities();
            //context.CLIENTES.Load();
            //clientesListBox.DataContext = context.CLIENTES.Local;

            var consulta = from    n in context.CLIENTES
                           where   n.genero == "MALE"
                           orderby n.nombre
                           select  n;
            clientesListBox.DataContext = new ObservableCollection<CLIENTE>(consulta.ToList());
        }
    }
}
