using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;

namespace eAgenda.Windows
{
    public partial class TelaCompromisso : Form
    {
        ControladorCompromisso controladorCompromisso = new ControladorCompromisso();

        ControladorContato controladorContato = new ControladorContato();

        public TelaCompromisso()
        {
            InitializeComponent();

            groupBoxContatos.Hide();

            ConfigurarTabelaContatos();
            ConfigurarTabelaCompromisso();
        }

        public void ConfigurarTabelaContatos()
        {
            dataSetContatoCompromisso.Clear();

            List<Contato> todosContatos = controladorContato.SelecionarTodos();

            foreach (Contato contato in todosContatos)
            {
                ConfiguraLinhasDaTabelaContato(contato);
            }
        }

        private void ConfiguraLinhasDaTabelaContato(Contato contato)
        {
            dataTableContatoCompromisso.Rows.Add(contato.Id, contato.Nome);
        }

        public void ConfigurarTabelaCompromisso()
        {
            dataSetCompromisso.Clear();

            List<Compromisso> todosCompromissos = controladorCompromisso.SelecionarTodos();

            foreach (Compromisso compromisso in todosCompromissos)
            {
                ConfiguraLinhasDaTabelaCompromisso(compromisso);
            }
        }

        private void ConfiguraLinhasDaTabelaCompromisso(Compromisso compromisso)
        {
            if (compromisso.Contato == null)
            {
                dataTableCompromisso.Rows.Add(compromisso.Id, compromisso.Local, compromisso.Data.ToShortDateString(),
                    compromisso.HoraInicio, compromisso.HoraTermino, compromisso.Link, compromisso.Assunto);
            }
            else {
                dataTableCompromisso.Rows.Add(compromisso.Id, compromisso.Local, compromisso.Data.ToShortDateString()
                    , compromisso.HoraInicio, compromisso.HoraTermino, compromisso.Link, compromisso.Assunto,
                    compromisso.Contato.Nome);
            }        
        }

        private void radioButtonPresencial_CheckedChanged(object sender, EventArgs e)
        {
            textBoxLocal.Enabled = true;
            textBoxLink.Enabled = false;
        }

        private void radioButtonRemoto_CheckedChanged(object sender, EventArgs e)
        {
            textBoxLocal.Enabled = false;
            textBoxLink.Enabled = true;
        }               

        private void botãoCadastrar_Click(object sender, EventArgs e)
        {
            string assunto = textBoxAssunto.Text;


            string local=null;
            string link=null;

            ObterLocal(ref local, ref link);
            ObterLink(ref local, ref link);

            DateTime data = Convert.ToDateTime(maskedTextBoxData.Text);

            TimeSpan horaInicio = ObterHoraInicio();

            TimeSpan horaTermino = ObterHoraFim();

            Contato contato = null;

            if (checkBoxSim.Checked == true)
            {
                contato = controladorContato.SelecionarPorId(SelecionarID(dataGridViewContatos));
            }           
            
            Compromisso compromissoInserir = new Compromisso(assunto, local, link, data, horaInicio, horaTermino, contato);

            controladorCompromisso.InserirNovo(compromissoInserir);

            MessageBox.Show("Compromisso cadastrado com sucesso!");

            ConfiguraLinhasDaTabelaCompromisso(compromissoInserir);

        }

        private void ObterLink(ref string local, ref string link)
        {
            if (radioButtonRemoto.Checked == true)
            {
                link = textBoxLink.Text;
                local = null;
            }
        }

        private void ObterLocal(ref string local, ref string link)
        {
            if (radioButtonPresencial.Checked == true)
            {
                local = textBoxLocal.Text;
                link = null;
            }
        }

        private static int SelecionarID(DataGridView tabela)
        {
            DataGridViewRow linhaSelecionada = tabela.SelectedRows[0];

            object idTarefaExcluir = linhaSelecionada.Cells[0].Value;

            int idSelecionado = Convert.ToInt32(idTarefaExcluir);

            return idSelecionado;
        }

        private TimeSpan ObterHoraInicio()
        {
            string strHoraInicio = maskedTextBoxHoraInicio.Text;
            string[] horaInicioArray = strHoraInicio.Split(':');
            TimeSpan horaInicio = new TimeSpan(int.Parse(horaInicioArray[0]), int.Parse(horaInicioArray[1]), 0);

            return horaInicio;
        }

        private TimeSpan ObterHoraFim()
        {
            string strHoraFim = maskedTextBoxHoraFim.Text;
            string[] horaFimArray = strHoraFim.Split(':');
            TimeSpan horaFim = new TimeSpan(int.Parse(horaFimArray[0]), int.Parse(horaFimArray[1]), 0);

            return horaFim;
        }

        public Compromisso EditarCompromissoSelecionado()
        {
            string assunto = textBoxAssunto.Text;


            string local = null;
            string link = null;

            ObterLocal(ref local, ref link);
            ObterLink(ref local, ref link);

            DateTime data = Convert.ToDateTime(maskedTextBoxData.Text);

            TimeSpan horaInicio = ObterHoraInicio();

            TimeSpan horaTermino = ObterHoraFim();

            Contato contato = null;

            if (checkBoxSim.Checked == true)
            {
                contato = controladorContato.SelecionarPorId(SelecionarID(dataGridViewContatos));
            }
            

            Compromisso compromissoInserir = new Compromisso(assunto, local, link, data, horaInicio, horaTermino, contato); 

            ConfiguraLinhasDaTabelaCompromisso(compromissoInserir);

            return compromissoInserir;
        }

        private string ExecutarEdição()
        {
            return controladorCompromisso.Editar(SelecionarID(dataGridCompromissos), EditarCompromissoSelecionado());
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ExecutarEdição();
            MessageBox.Show("Compromisso editado com sucesso!");
            ConfigurarTabelaCompromisso();
        }

        private void checkBoxSim_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSim.Checked == true)
            {
                groupBoxContatos.Show();
                groupBoxContatos.Enabled = true;
            }
            if(checkBoxSim.Checked == false)
            {
                groupBoxContatos.Hide();
                groupBoxContatos.Enabled = false;
            }
        }

        private void botãoExcluir_Click(object sender, EventArgs e)
        {
            ExecutarExclusão();
            MessageBox.Show("Compromisso excluído com sucesso!");
            ConfigurarTabelaCompromisso();
        }

        private void ExecutarExclusão()
        {
            if (dataGridCompromissos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum compromisso selecionado");
            }

            controladorCompromisso.Excluir(SelecionarID(dataGridCompromissos));
        }
    }
}
