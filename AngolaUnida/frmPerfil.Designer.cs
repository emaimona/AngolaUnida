namespace AngolaUnida
{
    partial class frmPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfil));
            this.lblNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEntrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.foto = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblMorada = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTelefone = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSexo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(4, 131);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(610, 33);
            this.lblNome.TabIndex = 100;
            this.lblNome.Text = "Emanuel Nzinga Maimona";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblSexo);
            this.panel1.Controls.Add(this.lblTelefone);
            this.panel1.Controls.Add(this.lblMorada);
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.shapeContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 441);
            this.panel1.TabIndex = 101;
            // 
            // btnEntrar
            // 
            this.btnEntrar.ActiveBorderThickness = 1;
            this.btnEntrar.ActiveCornerRadius = 20;
            this.btnEntrar.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnEntrar.ActiveForecolor = System.Drawing.Color.White;
            this.btnEntrar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEntrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEntrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntrar.BackgroundImage")));
            this.btnEntrar.ButtonText = "Fechar";
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.IdleBorderThickness = 1;
            this.btnEntrar.IdleCornerRadius = 20;
            this.btnEntrar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.btnEntrar.IdleForecolor = System.Drawing.Color.White;
            this.btnEntrar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEntrar.Location = new System.Drawing.Point(505, 385);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(86, 42);
            this.btnEntrar.TabIndex = 102;
            this.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.foto});
            this.shapeContainer2.Size = new System.Drawing.Size(614, 441);
            this.shapeContainer2.TabIndex = 101;
            this.shapeContainer2.TabStop = false;
            // 
            // foto
            // 
            this.foto.BackColor = System.Drawing.Color.White;
            this.foto.BackgroundImage = global::AngolaUnida.Properties.Resources.photo;
            this.foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foto.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.foto.BorderColor = System.Drawing.Color.Teal;
            this.foto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foto.Location = new System.Drawing.Point(248, 34);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(109, 93);
            this.foto.MouseHover += new System.EventHandler(this.foto_MouseHover);
            this.foto.MouseLeave += new System.EventHandler(this.foto_MouseLeave);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Location = new System.Drawing.Point(166, 241);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(73, 21);
            this.lblMorada.TabIndex = 103;
            this.lblMorada.Text = "Morada";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(166, 282);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(76, 21);
            this.lblTelefone.TabIndex = 103;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(166, 323);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(46, 21);
            this.lblSexo.TabIndex = 103;
            this.lblSexo.Text = "Sexo";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(166, 200);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 21);
            this.lblEmail.TabIndex = 103;
            this.lblEmail.Text = "E-mail";
            // 
            // frmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 441);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPerfil";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPerfil";
            this.Load += new System.EventHandler(this.frmPerfil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.OvalShape foto;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEntrar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMorada;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSexo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTelefone;
    }
}