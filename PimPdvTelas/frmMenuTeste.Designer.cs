namespace PimPdvTelas
{
    partial class frmMenuTeste
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuTeste));
            this.pnMenuVertical = new System.Windows.Forms.Panel();
            this.btnLogo = new System.Windows.Forms.PictureBox();
            this.btnRelatorio = new FontAwesome.Sharp.IconButton();
            this.btnColaborador = new FontAwesome.Sharp.IconButton();
            this.btnProduto = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.pictBoxLogo = new System.Windows.Forms.PictureBox();
            this.pnHorizontal = new System.Windows.Forms.Panel();
            this.btnMax = new FontAwesome.Sharp.IconButton();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNomeForms = new System.Windows.Forms.Label();
            this.iconMenu = new FontAwesome.Sharp.IconPictureBox();
            this.iconFilho = new FontAwesome.Sharp.IconPictureBox();
            this.pnForm = new System.Windows.Forms.Panel();
            this.pnMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogo)).BeginInit();
            this.pnHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFilho)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenuVertical
            // 
            this.pnMenuVertical.BackColor = System.Drawing.Color.Black;
            this.pnMenuVertical.Controls.Add(this.btnLogo);
            this.pnMenuVertical.Controls.Add(this.btnRelatorio);
            this.pnMenuVertical.Controls.Add(this.btnColaborador);
            this.pnMenuVertical.Controls.Add(this.btnProduto);
            this.pnMenuVertical.Controls.Add(this.btnHome);
            this.pnMenuVertical.Controls.Add(this.pictBoxLogo);
            this.pnMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.pnMenuVertical.Name = "pnMenuVertical";
            this.pnMenuVertical.Size = new System.Drawing.Size(200, 861);
            this.pnMenuVertical.TabIndex = 0;
            // 
            // btnLogo
            // 
            this.btnLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo.Image")));
            this.btnLogo.Location = new System.Drawing.Point(3, 3);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(70, 44);
            this.btnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogo.TabIndex = 0;
            this.btnLogo.TabStop = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRelatorio.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnRelatorio.IconColor = System.Drawing.Color.White;
            this.btnRelatorio.IconSize = 40;
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.Location = new System.Drawing.Point(0, 230);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRelatorio.Rotation = 0D;
            this.btnRelatorio.Size = new System.Drawing.Size(200, 60);
            this.btnRelatorio.TabIndex = 3;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnColaborador
            // 
            this.btnColaborador.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnColaborador.FlatAppearance.BorderSize = 0;
            this.btnColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColaborador.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColaborador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnColaborador.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnColaborador.IconColor = System.Drawing.Color.White;
            this.btnColaborador.IconSize = 40;
            this.btnColaborador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColaborador.Location = new System.Drawing.Point(0, 170);
            this.btnColaborador.Name = "btnColaborador";
            this.btnColaborador.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnColaborador.Rotation = 0D;
            this.btnColaborador.Size = new System.Drawing.Size(200, 60);
            this.btnColaborador.TabIndex = 2;
            this.btnColaborador.Text = "Colaborador";
            this.btnColaborador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColaborador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnColaborador.UseVisualStyleBackColor = true;
            this.btnColaborador.Click += new System.EventHandler(this.btnColaborador_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduto.FlatAppearance.BorderSize = 0;
            this.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProduto.IconChar = FontAwesome.Sharp.IconChar.Parking;
            this.btnProduto.IconColor = System.Drawing.Color.White;
            this.btnProduto.IconSize = 40;
            this.btnProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduto.Location = new System.Drawing.Point(0, 110);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProduto.Rotation = 0D;
            this.btnProduto.Size = new System.Drawing.Size(200, 60);
            this.btnProduto.TabIndex = 1;
            this.btnProduto.Text = "Produto";
            this.btnProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconSize = 40;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 50);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHome.Rotation = 0D;
            this.btnHome.Size = new System.Drawing.Size(200, 60);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Dashboard";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnDashbord_Click);
            // 
            // pictBoxLogo
            // 
            this.pictBoxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictBoxLogo.Name = "pictBoxLogo";
            this.pictBoxLogo.Size = new System.Drawing.Size(200, 50);
            this.pictBoxLogo.TabIndex = 0;
            this.pictBoxLogo.TabStop = false;
            // 
            // pnHorizontal
            // 
            this.pnHorizontal.BackColor = System.Drawing.Color.Black;
            this.pnHorizontal.Controls.Add(this.btnMax);
            this.pnHorizontal.Controls.Add(this.btnMin);
            this.pnHorizontal.Controls.Add(this.btnClose);
            this.pnHorizontal.Controls.Add(this.lblNomeForms);
            this.pnHorizontal.Controls.Add(this.iconMenu);
            this.pnHorizontal.Controls.Add(this.iconFilho);
            this.pnHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHorizontal.Location = new System.Drawing.Point(200, 0);
            this.pnHorizontal.Name = "pnHorizontal";
            this.pnHorizontal.Size = new System.Drawing.Size(1100, 50);
            this.pnHorizontal.TabIndex = 1;
            this.pnHorizontal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnHorizontal_Paint);
            this.pnHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHorizontal_MouseDown);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMax.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnMax.IconColor = System.Drawing.Color.White;
            this.btnMax.IconSize = 16;
            this.btnMax.Location = new System.Drawing.Point(1033, 16);
            this.btnMax.Name = "btnMax";
            this.btnMax.Rotation = 0D;
            this.btnMax.Size = new System.Drawing.Size(26, 23);
            this.btnMax.TabIndex = 6;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMin.IconColor = System.Drawing.Color.White;
            this.btnMin.IconSize = 16;
            this.btnMin.Location = new System.Drawing.Point(1011, 16);
            this.btnMin.Name = "btnMin";
            this.btnMin.Rotation = 0D;
            this.btnMin.Size = new System.Drawing.Size(16, 23);
            this.btnMin.TabIndex = 5;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1064, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNomeForms
            // 
            this.lblNomeForms.AutoSize = true;
            this.lblNomeForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeForms.ForeColor = System.Drawing.Color.White;
            this.lblNomeForms.Location = new System.Drawing.Point(94, 9);
            this.lblNomeForms.Name = "lblNomeForms";
            this.lblNomeForms.Size = new System.Drawing.Size(52, 20);
            this.lblNomeForms.TabIndex = 2;
            this.lblNomeForms.Text = "Home";
            // 
            // iconMenu
            // 
            this.iconMenu.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconMenu.IconColor = System.Drawing.Color.White;
            this.iconMenu.Location = new System.Drawing.Point(6, 3);
            this.iconMenu.Name = "iconMenu";
            this.iconMenu.Size = new System.Drawing.Size(32, 32);
            this.iconMenu.TabIndex = 2;
            this.iconMenu.TabStop = false;
            this.iconMenu.Click += new System.EventHandler(this.iconMenu_Click);
            // 
            // iconFilho
            // 
            this.iconFilho.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconFilho.IconColor = System.Drawing.Color.White;
            this.iconFilho.Location = new System.Drawing.Point(56, 3);
            this.iconFilho.Name = "iconFilho";
            this.iconFilho.Size = new System.Drawing.Size(32, 32);
            this.iconFilho.TabIndex = 2;
            this.iconFilho.TabStop = false;
            // 
            // pnForm
            // 
            this.pnForm.BackColor = System.Drawing.Color.Black;
            this.pnForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnForm.Location = new System.Drawing.Point(200, 50);
            this.pnForm.Name = "pnForm";
            this.pnForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnForm.Size = new System.Drawing.Size(1100, 811);
            this.pnForm.TabIndex = 2;
            // 
            // frmMenuTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 861);
            this.Controls.Add(this.pnForm);
            this.Controls.Add(this.pnHorizontal);
            this.Controls.Add(this.pnMenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMenuTeste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMenuTeste_Load);
            this.pnMenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogo)).EndInit();
            this.pnHorizontal.ResumeLayout(false);
            this.pnHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFilho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenuVertical;
        private System.Windows.Forms.Panel pnHorizontal;
        private FontAwesome.Sharp.IconButton btnRelatorio;
        private FontAwesome.Sharp.IconButton btnColaborador;
        private FontAwesome.Sharp.IconButton btnProduto;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.PictureBox pictBoxLogo;
        private System.Windows.Forms.PictureBox btnLogo;
        private FontAwesome.Sharp.IconPictureBox iconFilho;
        private FontAwesome.Sharp.IconPictureBox iconMenu;
        private System.Windows.Forms.Label lblNomeForms;
        private System.Windows.Forms.Panel pnForm;
        private FontAwesome.Sharp.IconButton btnMin;
        private System.Windows.Forms.Button btnClose;
        private FontAwesome.Sharp.IconButton btnMax;
    }
}

