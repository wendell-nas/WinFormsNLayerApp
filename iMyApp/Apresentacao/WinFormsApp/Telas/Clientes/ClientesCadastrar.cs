using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp.Telas.Clientes
{
    public partial class ClientesCadastrar : Form
    {
        //CONSTRUTOR
        public ClientesCadastrar()
        {
            InitializeComponent();

            var cliente = new Cliente();

            var colaborador = new Colaborador();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente
            {
                Cpf = txtCpf.Text,
                Nome = txtNomeCompleto.Text,
                Nascimento = Convert.ToDateTime(cmbBolsaEstudos.Text),
                Telefone = txtTelefone.Text,
                Email = txtEmail.Text,
            };

           

        }
    }
}
