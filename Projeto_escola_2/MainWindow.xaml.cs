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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Projeto_escola_2.Views;

namespace Projeto_escola_2
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt_cosultar_curso_Click(object sender, RoutedEventArgs e)
        {
            Lista_curso cha = new Lista_curso();
            cha.ShowDialog();
        }

        private void bt_cadastrar_curso_Click(object sender, RoutedEventArgs e)
        {
            Cadastro_curso cha = new Cadastro_curso();
            cha.ShowDialog();
        }

        private void bt_cadastrar_escola_Click(object sender, RoutedEventArgs e)
        {
            Cadastro_escola cha = new Cadastro_escola();
            cha.ShowDialog();
        }

        private void bt_cosultar_escola_Click(object sender, RoutedEventArgs e)
        {
            Lista_escola cha = new Lista_escola();
            cha.ShowDialog();
        }
    }
}
