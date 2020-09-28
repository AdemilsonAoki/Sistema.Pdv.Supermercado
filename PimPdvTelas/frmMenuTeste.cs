using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;

using FontAwesome.Sharp;

namespace PimPdvTelas
{
    public partial class frmMenuTeste : Form
    {
        private IconButton iconButton;
        private Panel leftBorder;
        private Form formFilho;
        public frmMenuTeste()
        {
            InitializeComponent();
            leftBorder = new Panel();
            leftBorder.Size = new Size(7, 60);
            pnMenuVertical.Controls.Add(leftBorder);
            DesignCustomizado();
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DEsativarBotao();
                iconButton = (IconButton)senderBtn;
                iconButton.BackColor = Color.FromArgb(112, 128, 144);
                iconButton.ForeColor = color;
                iconButton.TextAlign = ContentAlignment.MiddleCenter;
                iconButton.IconColor = color;
                iconButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                iconButton.ImageAlign = ContentAlignment.MiddleRight;


                leftBorder.BackColor = color;
                leftBorder.Location = new Point(0, iconButton.Location.Y);
                leftBorder.Visible = true;
                leftBorder.BringToFront();

                iconFilho.IconChar = iconButton.IconChar;
                iconFilho.IconColor = color;


            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(77, 121, 255);
            public static Color color6 = Color.FromArgb(251, 100, 0);
            public static Color color7 = Color.FromArgb(230, 230, 0);
            public static Color color8 = Color.FromArgb(0, 0, 0);


        }

        private void DEsativarBotao()
        {
            if(iconButton != null)
            {
                iconButton.BackColor = Color.FromArgb(0, 0, 0);
                iconButton.ForeColor = Color.Gainsboro;
                iconButton.TextAlign = ContentAlignment.MiddleLeft;
                iconButton.IconColor = Color.Gainsboro;
                iconButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                iconButton.ImageAlign = ContentAlignment.MiddleLeft;
               

            }
        }



     

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmDashboard());

            ActivateButton(sender, RGBColors.color1);
            pnHorizontal.BackColor = RGBColors.color8;

            lblNomeForms.Text = "Dashboard";


        }


        private void btnLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }


        private void Reset()
        {
            if (iconFilho != null)
            {
                DEsativarBotao();
                leftBorder.Visible = false;
                iconFilho.IconChar = IconChar.Home;
                iconFilho.IconColor = Color.White;
            }

        }
      

        private void pnHorizontal_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm.ReleaseCapture();
            MoverForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmMenuTeste_Load(object sender, EventArgs e)
        {

        }

        private void AbrirForm(Form formFilho)
        {
            if (this.formFilho != null)
            {
                this.formFilho.Close();
            }
            this.formFilho = formFilho;
            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;
            pnForm.Controls.Add(formFilho);
            formFilho.BringToFront();
            formFilho.Show();
        }


        private void iconMenu_Click(object sender, EventArgs e)
        {
            string produto = "Produto";
            string colaborador = "Colaborador";
            string dashBoard = "Dashboard";
            string relatorio = "Relatório";
            string salvar = "Salvar";
            string pesquisa = "Pesquisa"; 



            if (pnMenuVertical.Width == 200)
            {


                btnColaborador.Text = "";
                btnHome.Text = "";
                btnProduto.Text = "";
                btnRelatorio.Text = "";
                pnMenuVertical.Width = 70;
                btnPesquisaColaborador.Text = "";
                btnPesquisaProduto.Text = "";
                btnPesquisaRelatorio.Text = "";
                btnSalvarColaborador.Text = "";
                btnSalvarProduto.Text = "";
            }
            else
            {
                btnColaborador.Text = colaborador;
                btnHome.Text = dashBoard;
                btnProduto.Text = produto;
                btnRelatorio.Text = relatorio;
                btnPesquisaColaborador.Text = pesquisa;
                btnPesquisaProduto.Text = pesquisa;
                btnPesquisaRelatorio.Text = pesquisa;
                btnSalvarColaborador.Text = salvar;
                btnSalvarProduto.Text = salvar;

                pnMenuVertical.Width = 200;
            }
        }

       

        private void pnHorizontal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DesignCustomizado()
        {
            pnSubMenuColaborador.Visible = false;
            pnSubMenuRelatorio.Visible = false;
            pnSubMenuProduto.Visible = false;
            
        }

        private void OcultarSubMenu()
        {
            if (pnSubMenuColaborador.Visible == true)
                pnSubMenuColaborador.Visible = false;
            if (pnSubMenuProduto.Visible == true)
                pnSubMenuProduto.Visible = false;
            if (pnSubMenuRelatorio.Visible == true)
                pnSubMenuRelatorio.Visible = false;
        }
        private void showSubMenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                OcultarSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btnProduto_Click_1(object sender, EventArgs e)
        {
      
            ActivateButton(sender, RGBColors.color2);
            pnHorizontal.BackColor = RGBColors.color7;

            lblNomeForms.Text = "Produto";
            showSubMenu(pnSubMenuProduto);
        }



        private void btnPesquisaProduto_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();

        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmProduto());

            OcultarSubMenu();

        }

        private void btnColaborador_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            pnHorizontal.BackColor = RGBColors.color5;
            lblNomeForms.Text = "Colaborador";
            showSubMenu(pnSubMenuColaborador);
        }

        private void btnSalvarColaborador_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new frmColaborador());

            OcultarSubMenu();

        }

        private void btnPesquisaColaborador_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBColors.color4);
            pnHorizontal.BackColor = RGBColors.color6;
            lblNomeForms.Text = "Relatório";
            showSubMenu(pnSubMenuRelatorio);
        }

        private void btnPesquisaRelatorio_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmRelatorio());

            OcultarSubMenu();

        }
    }
}
