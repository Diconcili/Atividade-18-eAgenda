using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.ContatoModule;

namespace eAgenda.Windows
{
    public partial class TelaContato : Form
    {
        ControladorContato controlador = new ControladorContato();

        public TelaContato()
        {
          InitializeComponent();

            ConfigurarTabela();        
        }

        public void ConfigurarTabela()
        {
            dataSetContatos.Clear();

            List<Contato> todosContatos = controlador.SelecionarTodos();

            foreach (Contato contato in todosContatos)
            {
                ConfiguraLinhasDaTabela(contato);
            }
        }

        private void ConfiguraLinhasDaTabela(Contato contato)
        {
            dataTableContato.Rows.Add(contato.Id, contato.Nome, contato.Email,
                contato.Telefone, contato.Cargo, contato.Empresa);
        }

        private void botãoCadastrar_Click(object sender, EventArgs e)
        {
            string nomeInserir = textBoxNomeContato.Text;

            string emailInserir = textBoxEmailContato.Text;

            string telefoneInserir = maskedTextBoxTelefone.Text;

            string cargoInserir = textBoxCargo.Text;

            string empresa = textBoxEmpresa.Text;
            
            Contato contatoInserir = new Contato(nomeInserir, emailInserir, telefoneInserir, empresa, cargoInserir);

            controlador.InserirNovo(contatoInserir);

            MessageBox.Show("Contato cadastrado com sucesso!");

            ConfiguraLinhasDaTabela(contatoInserir);
        }

        private static int SelecionarID(DataGridView tabela)
        {
            DataGridViewRow linhaSelecionada = tabela.SelectedRows[0];

            object idTarefaExcluir = linhaSelecionada.Cells[0].Value;

            int idSelecionado = Convert.ToInt32(idTarefaExcluir);

            return idSelecionado;
        }

        private void botãoExcluir_Click(object sender, EventArgs e)
        {
            ExecutarExclusão();
            MessageBox.Show("Contato excluído com sucesso!");
            ConfigurarTabela();
        }

        private void ExecutarExclusão()
        {
            if (dataGridContato.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum contato selecionado");
            }

            controlador.Excluir(SelecionarID(dataGridContato));
        }

        private void botãoEditar_Click(object sender, EventArgs e)
        {
            ExecutarEdição();
            MessageBox.Show("Contato editado com sucesso!");
            ConfigurarTabela();
        }

        public string ExecutarEdição()
        {
            return controlador.Editar(SelecionarID(dataGridContato), EditarContatoSelecionado());
        }

        public Contato EditarContatoSelecionado()
        {
            string nomeInserir = textBoxNomeContato.Text;

            string emailInserir = textBoxEmailContato.Text;

            string telefoneInserir = maskedTextBoxTelefone.Text;

            string cargoInserir = textBoxCargo.Text;

            string empresa = textBoxEmpresa.Text;

            Contato contatoEditar = new Contato(nomeInserir, emailInserir, telefoneInserir, empresa, cargoInserir);
           
            ConfigurarTabela();

            return contatoEditar;
        }
    }
}
