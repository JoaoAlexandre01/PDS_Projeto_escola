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
using Projeto_escola_2.Models;

namespace Projeto_escola_2.Views
{
    /// <summary>
    /// Lógica interna para Lista_escola.xaml
    /// </summary>
    public partial class Lista_escola : Window
    {
        public Lista_escola()
        {
            InitializeComponent();
            Loaded += Lista_escola_Loaded;
        }

        private void Lista_escola_Loaded(object sender, RoutedEventArgs e)
        {
            CarregarListagem();
        }
        private void Button_Atualizar_Click(object sender, RoutedEventArgs e)
        {
            var escolaSelected = dataGridEscola.SelectedItem as Escola;
            var view = new Cadastro_escola(escolaSelected);
            view.ShowDialog();
            CarregarListagem();
        }

        private void Button_Remover_Click(object sender, RoutedEventArgs e)
        {
            var escolaSelecionada = dataGridEscola.SelectedItem as Escola;
            var resultado = MessageBox.Show($"Deseja realmente remover a escola `{escolaSelecionada.NomeFantasia}` ?", "Confirmação de Exclusão",
                MessageBoxButton.YesNo, MessageBoxImage.Warning);

            try
            {
                if (resultado == MessageBoxResult.Yes)
                {
                    var dao = new EscolaDAO();
                    dao.Delete(escolaSelecionada);
                    MessageBox.Show("Registro removido com Sucesso!");
                    CarregarListagem();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregarListagem()
        {
            try
            {
                var dao = new EscolaDAO();
                List<Escola> listaEscolas = dao.List();
                dataGridEscola.ItemsSource = listaEscolas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
