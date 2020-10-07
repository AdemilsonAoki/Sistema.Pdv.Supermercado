using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimPdvTelas
{
    public partial class frmFornecedor : Form
    {
        Conexao conexao = new Conexao();
        public frmFornecedor()
        {
            InitializeComponent();
            dgvFornecedor.DataSource = conexao.ListarColaborador();

        }
    }
}
