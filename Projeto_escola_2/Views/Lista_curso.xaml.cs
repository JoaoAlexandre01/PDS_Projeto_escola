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
    /// Lógica interna para Lista_curso.xaml
    /// </summary>
    public partial class Lista_curso : Window
    {
        public Lista_curso()
        {
            InitializeComponent();
            Loaded += Lista_curso_Loaded;
        }

        private void Lista_curso_Loaded(object sender, RoutedEventArgs e)
        {
            CarregarListagem();
        }
        private void CarregarListagem()
        {
            try
            {
                var dao = new CursoDAO();
                List<Curso> listaCursos = dao.List();

                dataGridCurso.ItemsSource = listaCursos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Button_Atualizar_Click(object sender, RoutedEventArgs e)
        {
            var cursoSelected = dataGridCurso.SelectedItem as Curso;
            var view = new Cadastro_curso(cursoSelected);
            view.ShowDialog();
            CarregarListagem();
        }

        private void Button_Remover_Click(object sender, RoutedEventArgs e)
        {
            var cursoSelected = dataGridCurso.SelectedItem as Curso;

            var result = MessageBox.Show($"Deseja realmente excluir o curso '{cursoSelected.Nome}'?", "Confirmação de Exclusão",
                    MessageBoxButton.YesNo, MessageBoxImage.Warning);

            try
            {
                if (result == MessageBoxResult.Yes)
                {
                    var dao = new CursoDAO();
                    dao.Delete(cursoSelected);
                    CarregarListagem();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
