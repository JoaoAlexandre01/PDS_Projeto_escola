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
    /// Lógica interna para Cadastro_curso.xaml
    /// </summary>
    public partial class Cadastro_curso : Window
    {
        private Curso _cadastro = new Curso();
        public Cadastro_curso()
        {
            InitializeComponent();
        }
        public Cadastro_curso(Curso cadastro)
        {
            InitializeComponent();
            Loaded += Cadastro_curso_Loaded;
            _cadastro = cadastro;
        }

        private void Cadastro_curso_Loaded(object sender, RoutedEventArgs e)
        {
            txtCargaHoraria.Text = _cadastro.CargaHoraria;
            txtNome.Text = _cadastro.Nome;
            cbTurno.Text = _cadastro.Turno;
            txtDescricao.Text = _cadastro.Descricao;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _cadastro.Nome = txtNome.Text;
            _cadastro.Turno = cbTurno.Text;
            _cadastro.CargaHoraria = txtCargaHoraria.Text;
            _cadastro.Descricao = txtDescricao.Text;

            try
            {
                var dao = new CursoDAO();

                if (_cadastro.Id > 0)
                {
                    dao.Update(_cadastro);
                    MessageBox.Show("Registro Atualizado com Sucesso!");
                }
                else
                {
                    dao.Insert(_cadastro);
                    MessageBox.Show("Registro Salvo com Sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
