namespace AngolaUnida
{
    partial class frmQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestion));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnSim = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNao = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSim);
            this.panel1.Controls.Add(this.btnNao);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 253);
            this.panel1.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.lblInfo.Location = new System.Drawing.Point(84, 67);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(185, 110);
            this.lblInfo.TabIndex = 99;
            this.lblInfo.Text = "A senha introduzida está incorrecta. Porfavor verfique";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblTitle.Location = new System.Drawing.Point(0, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(312, 23);
            this.lblTitle.TabIndex = 103;
            this.lblTitle.Text = "Acesso Negado";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape1,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(311, 253);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalShape1
            // 
            this.ovalShape1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ovalShape1.BackgroundImage")));
            this.ovalShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ovalShape1.BorderColor = System.Drawing.Color.Transparent;
            this.ovalShape1.Location = new System.Drawing.Point(25, 98);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(50, 43);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.rectangleShape1.BorderWidth = 5;
            this.rectangleShape1.Location = new System.Drawing.Point(0, 0);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(311, 253);
            // 
            // btnSim
            // 
            this.btnSim.ActiveBorderThickness = 1;
            this.btnSim.ActiveCornerRadius = 20;
            this.btnSim.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnSim.ActiveForecolor = System.Drawing.Color.White;
            this.btnSim.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSim.BackColor = System.Drawing.SystemColors.Control;
            this.btnSim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSim.BackgroundImage")));
            this.btnSim.ButtonText = "Sim";
            this.btnSim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSim.ForeColor = System.Drawing.Color.White;
            this.btnSim.IdleBorderThickness = 1;
            this.btnSim.IdleCornerRadius = 20;
            this.btnSim.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.btnSim.IdleForecolor = System.Drawing.Color.White;
            this.btnSim.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSim.Location = new System.Drawing.Point(69, 197);
            this.btnSim.Margin = new System.Windows.Forms.Padding(5);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(87, 42);
            this.btnSim.TabIndex = 98;
            this.btnSim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNao
            // 
            this.btnNao.ActiveBorderThickness = 1;
            this.btnNao.ActiveCornerRadius = 20;
            this.btnNao.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnNao.ActiveForecolor = System.Drawing.Color.White;
            this.btnNao.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnNao.BackColor = System.Drawing.SystemColors.Control;
            this.btnNao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNao.BackgroundImage")));
            this.btnNao.ButtonText = "Não";
            this.btnNao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNao.ForeColor = System.Drawing.Color.White;
            this.btnNao.IdleBorderThickness = 1;
            this.btnNao.IdleCornerRadius = 20;
            this.btnNao.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.btnNao.IdleForecolor = System.Drawing.Color.White;
            this.btnNao.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnNao.Location = new System.Drawing.Point(166, 197);
            this.btnNao.Margin = new System.Windows.Forms.Padding(5);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(87, 42);
            this.btnNao.TabIndex = 99;
            this.btnNao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 253);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuestion";
            this.Text = "frmInfo";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label lblTitle;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private System.Windows.Forms.Label lblInfo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSim;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNao;
    }
}