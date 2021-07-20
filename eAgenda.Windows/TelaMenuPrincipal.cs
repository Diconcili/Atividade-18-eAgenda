using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.Windows
{
    public partial class TelaMenuPrincipal : Form
    {
        public TelaMenuPrincipal()
        {
            InitializeComponent();
        }        

        private void botãoTarefas_Click(object sender, EventArgs e)
        {
            TelaTarefa novaTela = new TelaTarefa();
            novaTela.Visible = true;
            
        }

        private void botãoContatos_Click(object sender, EventArgs e)
        {
            TelaContato novaTela = new TelaContato();
            novaTela.Visible = true;
        }

        private void botãoCompromissos_Click(object sender, EventArgs e)
        {
            TelaCompromisso novaTela = new TelaCompromisso();
            novaTela.Visible = true;
        }

        private void botãoSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
