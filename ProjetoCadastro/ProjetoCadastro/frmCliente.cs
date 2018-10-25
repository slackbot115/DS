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
    public partial class frmCliente : Form
    {
        int atual = 0;
        char flag = ' ';

        private void Mostrar()
        {
            lblCodigo.Text = frmPrincipal.cdFornecedor[atual].ToString();
            txtNome.Text = frmPrincipal.nomeFornecedor[atual];
            txtEndereco.Text = frmPrincipal.enderecoCliente[atual];
            txtBairro.Text = frmPrincipal.bairroCliente[atual];
            txtEstado.Text = frmPrincipal.estadoCliente[atual];
            txtCPF.Text = frmPrincipal.cidadeCliente[atual];
            txtCEP.Text = frmPrincipal.cepCliente[atual];
            txtRG.Text = frmPrincipal.rgCliente[atual];
        }

        public void habilitar()
        {
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtEstado.Enabled = true;
            txtCPF.Enabled = true;
            txtCidade.Enabled = true;
            txtCEP.Enabled = true;
            txtRG.Enabled = true;
            ////////////////////////////
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
        }

        public void desabilitar()
        {
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtEstado.Enabled = false;
            txtCPF.Enabled = false;
            txtCidade.Enabled = false;
            txtCEP.Enabled = false;
            txtRG.Enabled = false;
            ///////////////////////////
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
        }

        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            desabilitar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            desabilitar();
            if (flag == 'N')
            {
                frmPrincipal.cdCliente[frmPrincipal.indiceCliente] = frmPrincipal.indiceCliente + 1;
                frmPrincipal.nomeCliente[frmPrincipal.indiceCliente] = txtNome.Text;
                frmPrincipal.enderecoCliente[frmPrincipal.indiceCliente] = txtEndereco.Text;
                frmPrincipal.estadoCliente[frmPrincipal.indiceCliente] = txtEstado.Text;
                frmPrincipal.cpfCliente[frmPrincipal.indiceCliente] = txtCPF.Text;
                frmPrincipal.cidadeCliente[frmPrincipal.indiceCliente] = txtCidade.Text;
                frmPrincipal.cepCliente[frmPrincipal.indiceCliente] = txtCEP.Text;
                frmPrincipal.rgCliente[frmPrincipal.indiceCliente] = txtRG.Text;
                atual = frmPrincipal.indiceCliente;
                frmPrincipal.indiceCliente++;
            }
            else
            {
                frmPrincipal.nomeCliente[atual] = txtNome.Text;
                frmPrincipal.enderecoCliente[atual] = txtEndereco.Text;
                frmPrincipal.estadoCliente[atual] = txtEstado.Text;
                frmPrincipal.cpfCliente[atual] = txtCPF.Text;
                frmPrincipal.cidadeCliente[atual] = txtCidade.Text;
                frmPrincipal.cepCliente[atual] = txtCEP.Text;
                frmPrincipal.rgCliente[atual] = txtRG.Text;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtEstado.Text = "";
            txtBairro.Text = "";
            txtCPF.Text = "";
            txtCidade.Text = "";
            txtCEP.Text = "";
            txtRG.Text = "";
            if (frmPrincipal.indiceCliente < 10)
            habilitar();
            flag = 'N';
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (frmPrincipal.indiceCliente > 0)
            habilitar();
            flag = 'A';
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitar();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (atual < frmPrincipal.indiceCliente - 1)
            {
                atual++;
                Mostrar();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (atual > 0)
            {
                atual--;
                Mostrar();
            }
        }
    }
}
