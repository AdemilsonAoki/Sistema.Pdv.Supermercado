﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
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
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmProduto());
            ActivateButton(sender, RGBColors.color2);

        }

        private void btnColaborador_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmColaborador());
            ActivateButton(sender, RGBColors.color3);

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmRelatorio());

            ActivateButton(sender, RGBColors.color4);

        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }


        private void Reset()
        {
            DEsativarBotao();
            leftBorder.Visible = false;
            iconFilho.IconChar = iconButton.IconChar;
            iconFilho.IconColor = Color.White;
    

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnHorizontal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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



            if (pnMenuVertical.Width == 200)
            {


                btnColaborador.Text = "";
                btnHome.Text = "";
                btnProduto.Text = "";
                btnRelatorio.Text = "";
                pnMenuVertical.Width = 70;
            }
            else
            {
                btnColaborador.Text = colaborador;
                btnHome.Text = dashBoard;
                btnProduto.Text = produto;
                btnRelatorio.Text = relatorio;

                pnMenuVertical.Width = 200;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
