using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class frmPrincipal : Form
    {
        public static int indiceUsuario = 0;

        public static int[] cdUsuario = new int[10];
        public static string[] nomeUsuario = new string[10];
        public static string[] loginUsuario = new string[10];
        public static string[] nivelUsuario = new string[10];
        public static string[] senhaUsuario = new string[10];

        public static int indiceCliente = 0;

        public static int[] cdCliente = new int[10];
        public static string[] nomeCliente = new string[10];
        public static string[] enderecoCliente = new string[10];
        public static string[] bairroCliente = new string[10];
        public static string[] estadoCliente = new string[10];
        public static string[] cpfCliente = new string[10];
        public static string[] cidadeCliente = new string[10];
        public static string[] cepCliente = new string[10];
        public static string[] rgCliente = new string[10];

        public static int indiceFornecedor = 0;

        public static int[] cdFornecedor = new int[10];
        public static string[] nomeFornecedor = new string[10];
        public static string[] enderecoFornecedor = new string[10];
        public static string[] bairroFornecedor = new string[10];
        public static string[] estadoFornecedor = new string[10];
        public static string[] cnpjFornecedor = new string[10];
        public static string[] cidadeFornecedor = new string[10];
        public static string[] cepFornecedor = new string[10];
        public static string[] ieFornecedor = new string[10];



        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmUsuario u = new frmUsuario();
            u.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente c = new frmCliente();
            c.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor f = new frmFornecedor();
            f.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
