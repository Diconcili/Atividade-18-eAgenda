using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;

namespace eAgenda.Windows
{
    public partial class TelaTarefa : Form
    {
        ControladorTarefa controlador = new ControladorTarefa();

        PrioridadeEnum prioridadeInserir = new PrioridadeEnum();

        public TelaTarefa()
        {
            InitializeComponent();

            
        }

        public void ConfigurarTabelaTodasTarefas()
        {
            dataSetTarefas.Clear();

            List<Tarefa> todasTarefas = controlador.SelecionarTodos();

            foreach (Tarefa tarefa in todasTarefas)
            {
                ConfiguraLinhasDaTabela(tarefa);
            }
        }

        public void ConfigurarTabelaTarefasConcluidas()
        {
            dataSetTarefas.Clear();

            List<Tarefa> tarefasConcluidas = controlador.SelecionarTodasTarefasConcluidas();

            foreach (Tarefa tarefaConcluida in tarefasConcluidas)
            {
                ConfiguraLinhasDaTabela(tarefaConcluida);
            }
        }

        public void ConfigurarTabelaTarefasPendentes()
        {
            dataSetTarefas.Clear();

            List<Tarefa> tarefasPendentes = controlador.SelecionarTodasTarefasPendentes();

            foreach (Tarefa tarefaPendente in tarefasPendentes)
            {
                ConfiguraLinhasDaTabela(tarefaPendente);
            }
        }

        private void ConfiguraLinhasDaTabela(Tarefa tarefa)
        {
            dataTableTarefa.Rows.Add(tarefa.Id, tarefa.Titulo, tarefa.Prioridade,
                tarefa.Percentual, tarefa.DataCriacao.ToShortDateString());
        }


        private void comboBoxPrioridades_SelecionarItem(object sender, EventArgs e)
        {
            switch (comboBoxPrioridades.SelectedIndex)
            {
                case 0: prioridadeInserir = (PrioridadeEnum)2;
                    break;
                case 1: prioridadeInserir = (PrioridadeEnum)1;
                    break;
                case 2: prioridadeInserir = (PrioridadeEnum)0;
                    break;
            }
        }

        private void botãoCadastrarNovaTarefa_Click(object sender, EventArgs e)
        {
            string tituloTarefaInserir = textBoxTituloTarefa.Text;            

            DateTime dataCriaçãoInserir = Convert.ToDateTime(maskedTextBoxDataCriação.Text);

            int percentualInserir = Convert.ToInt32(maskedTextBoxPorcentagem.Text);

            DateTime dataConclusãoInserir = Convert.ToDateTime(maskedTextBoxDataConclusão.Text);
                        

            Tarefa tarefaInserir = new Tarefa(tituloTarefaInserir,dataCriaçãoInserir, prioridadeInserir);

            tarefaInserir.Percentual = percentualInserir;

            tarefaInserir.DataConclusao = dataConclusãoInserir;

            controlador.InserirNovo(tarefaInserir);

            MessageBox.Show("Tarefa cadastrada com sucesso!");
        }

        private void botãoTarefasConcluídas_Click(object sender, EventArgs e)
        {
            ConfigurarTabelaTarefasConcluidas();
        }

        private void TelaTarefa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'eAgendaDBDataSet.TBTarefa'. Você pode movê-la ou removê-la conforme necessário.
            

        }

        private void botãoVisualizarTodasTarefas_Click(object sender, EventArgs e)
        {
            ConfigurarTabelaTodasTarefas();
        }

        private void botãoTarefasPendentes_Click(object sender, EventArgs e)
        {
            ConfigurarTabelaTarefasPendentes();
        }

        private void botãoEditar_Click(object sender, EventArgs e)
        {
            ExecutarEdição();
            MessageBox.Show("Tarefa editada com sucesso!");
        }

        public string ExecutarEdição()
        {
            return controlador.Editar(SelecionarID(dataGridTarefas), EditarTarefaSelecionada());
        }

        private static int SelecionarID(DataGridView tabela)
        {
            DataGridViewRow linhaSelecionada = tabela.SelectedRows[0];

            object idTarefaExcluir = linhaSelecionada.Cells[0].Value;

            int idSelecionado = Convert.ToInt32(idTarefaExcluir);

            return idSelecionado;
        }

        public Tarefa EditarTarefaSelecionada()
        {
            string tituloTarefaEditar = textBoxTituloTarefa.Text;

            DateTime dataCriaçãoEditar = Convert.ToDateTime(maskedTextBoxDataCriação.Text);

            int percentualEditar = Convert.ToInt32(maskedTextBoxPorcentagem.Text);

            DateTime dataConclusãoEditar = Convert.ToDateTime(maskedTextBoxDataConclusão.Text);

            Tarefa tarefaEditar = new Tarefa(tituloTarefaEditar, dataCriaçãoEditar, prioridadeInserir);

            tarefaEditar.Percentual = percentualEditar;

            tarefaEditar.DataConclusao = dataConclusãoEditar;            

            return tarefaEditar;
        }

        private void ExecutarExclusão()
        {
            if (dataGridTarefas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma tarefa selecionada");
            }

            controlador.Excluir(SelecionarID(dataGridTarefas));            
        }

        private void botãoExcluir_Click(object sender, EventArgs e)
        {
            ExecutarExclusão();
            MessageBox.Show("Tarefa excluída com sucesso!");
        }
    }
}
