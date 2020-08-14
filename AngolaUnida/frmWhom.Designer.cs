namespace AngolaUnida
{
    partial class frmWhom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWhom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblnome = new System.Windows.Forms.Label();
            this.btnSair = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnInstituicao = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDoador = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCarente = new Bunifu.Framework.UI.BunifuTileButton();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.b3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.b2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.b1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lblnome);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnInstituicao);
            this.panel1.Controls.Add(this.btnDoador);
            this.panel1.Controls.Add(this.btnCarente);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 342);
            this.panel1.TabIndex = 0;
            // 
            // lblnome
            // 
            this.lblnome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.lblnome.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblnome.ForeColor = System.Drawing.Color.White;
            this.lblnome.Location = new System.Drawing.Point(77, 34);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(486, 53);
            this.lblnome.TabIndex = 11;
            this.lblnome.Text = "Quem é você?";
            this.lblnome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSair
            // 
            this.btnSair.ActiveBorderThickness = 1;
            this.btnSair.ActiveCornerRadius = 20;
            this.btnSair.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnSair.ActiveForecolor = System.Drawing.Color.White;
            this.btnSair.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSair.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.ButtonText = "Sair";
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.IdleBorderThickness = 1;
            this.btnSair.IdleCornerRadius = 20;
            this.btnSair.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.btnSair.IdleForecolor = System.Drawing.Color.White;
            this.btnSair.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSair.Location = new System.Drawing.Point(524, 293);
            this.btnSair.Margin = new System.Windows.Forms.Padding(5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(87, 42);
            this.btnSair.TabIndex = 8;
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnInstituicao
            // 
            this.btnInstituicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.btnInstituicao.color = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.btnInstituicao.colorActive = System.Drawing.Color.Teal;
            this.btnInstituicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstituicao.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnInstituicao.ForeColor = System.Drawing.Color.White;
            this.btnInstituicao.Image = ((System.Drawing.Image)(resources.GetObject("btnInstituicao.Image")));
            this.btnInstituicao.ImagePosition = 20;
            this.btnInstituicao.ImageZoom = 50;
            this.btnInstituicao.LabelPosition = 41;
            this.btnInstituicao.LabelText = "Instituição";
            this.btnInstituicao.Location = new System.Drawing.Point(434, 132);
            this.btnInstituicao.Margin = new System.Windows.Forms.Padding(6);
            this.btnInstituicao.Name = "btnInstituicao";
            this.btnInstituicao.Size = new System.Drawing.Size(151, 141);
            this.btnInstituicao.TabIndex = 7;
            this.btnInstituicao.Click += new System.EventHandler(this.btnInstituicao_Click);
            // 
            // btnDoador
            // 
            this.btnDoador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.btnDoador.color = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.btnDoador.colorActive = System.Drawing.Color.Teal;
            this.btnDoador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoador.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnDoador.ForeColor = System.Drawing.Color.White;
            this.btnDoador.Image = ((System.Drawing.Image)(resources.GetObject("btnDoador.Image")));
            this.btnDoador.ImagePosition = 20;
            this.btnDoador.ImageZoom = 50;
            this.btnDoador.LabelPosition = 41;
            this.btnDoador.LabelText = "Doador";
            this.btnDoador.Location = new System.Drawing.Point(238, 133);
            this.btnDoador.Margin = new System.Windows.Forms.Padding(6);
            this.btnDoador.Name = "btnDoador";
            this.btnDoador.Size = new System.Drawing.Size(151, 141);
            this.btnDoador.TabIndex = 6;
            this.btnDoador.Click += new System.EventHandler(this.btnDoador_Click);
            // 
            // btnCarente
            // 
            this.btnCarente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.btnCarente.color = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.btnCarente.colorActive = System.Drawing.Color.Teal;
            this.btnCarente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarente.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnCarente.ForeColor = System.Drawing.Color.White;
            this.btnCarente.Image = ((System.Drawing.Image)(resources.GetObject("btnCarente.Image")));
            this.btnCarente.ImagePosition = 20;
            this.btnCarente.ImageZoom = 50;
            this.btnCarente.LabelPosition = 41;
            this.btnCarente.LabelText = "Carente";
            this.btnCarente.Location = new System.Drawing.Point(44, 132);
            this.btnCarente.Margin = new System.Windows.Forms.Padding(6);
            this.btnCarente.Name = "btnCarente";
            this.btnCarente.Size = new System.Drawing.Size(151, 141);
            this.btnCarente.TabIndex = 5;
            this.btnCarente.Click += new System.EventHandler(this.btnCarente_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.b3,
            this.b2,
            this.b1});
            this.shapeContainer1.Size = new System.Drawing.Size(628, 342);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.b3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.b3.BorderWidth = 12;
            this.b3.CornerRadius = 3;
            this.b3.Location = new System.Drawing.Point(433, 132);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(151, 141);
            this.b3.Click += new System.EventHandler(this.btnInstituicao_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.b2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.b2.BorderWidth = 12;
            this.b2.CornerRadius = 3;
            this.b2.Location = new System.Drawing.Point(237, 132);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(151, 141);
            this.b2.Click += new System.EventHandler(this.btnDoador_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.b1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.b1.BorderWidth = 12;
            this.b1.CornerRadius = 3;
            this.b1.Location = new System.Drawing.Point(43, 132);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(151, 141);
            this.b1.Click += new System.EventHandler(this.btnCarente_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-9, 56);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(649, 8);
            this.bunifuSeparator1.TabIndex = 13;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmWhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 342);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWhom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTileButton btnCarente;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSair;
        private Bunifu.Framework.UI.BunifuTileButton btnInstituicao;
        private Bunifu.Framework.UI.BunifuTileButton btnDoador;
        private System.Windows.Forms.Label lblnome;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape b1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape b3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape b2;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}