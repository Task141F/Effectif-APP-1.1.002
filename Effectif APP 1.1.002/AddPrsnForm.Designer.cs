namespace Effectif_APP_1._1._002
{
    partial class AddPrsnForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.FrstNameLabel = new System.Windows.Forms.Label();
            this.RgstrNbrLabel = new System.Windows.Forms.Label();
            this.NameTxtBx = new System.Windows.Forms.TextBox();
            this.FrstNameTxtBx = new System.Windows.Forms.TextBox();
            this.RgstrNbrTxtBx = new System.Windows.Forms.TextBox();
            this.buttonAddPct = new System.Windows.Forms.Button();
            this.PrsnPctrBx = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrsnPctrBx)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MainPanel.Controls.Add(this.PrsnPctrBx);
            this.MainPanel.Controls.Add(this.buttonAddPct);
            this.MainPanel.Controls.Add(this.RgstrNbrTxtBx);
            this.MainPanel.Controls.Add(this.FrstNameTxtBx);
            this.MainPanel.Controls.Add(this.NameTxtBx);
            this.MainPanel.Controls.Add(this.buttonAdd);
            this.MainPanel.Controls.Add(this.NameLabel);
            this.MainPanel.Controls.Add(this.FrstNameLabel);
            this.MainPanel.Controls.Add(this.RgstrNbrLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(464, 686);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonAdd.Location = new System.Drawing.Point(180, 482);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 29);
            this.buttonAdd.TabIndex = 84;
            this.buttonAdd.Text = "AJOUTER";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.NameLabel.Location = new System.Drawing.Point(41, 227);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(81, 25);
            this.NameLabel.TabIndex = 82;
            this.NameLabel.Text = "Nom";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // FrstNameLabel
            // 
            this.FrstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.FrstNameLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrstNameLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.FrstNameLabel.Location = new System.Drawing.Point(41, 287);
            this.FrstNameLabel.Name = "FrstNameLabel";
            this.FrstNameLabel.Size = new System.Drawing.Size(81, 25);
            this.FrstNameLabel.TabIndex = 81;
            this.FrstNameLabel.Text = "Prénom";
            this.FrstNameLabel.Click += new System.EventHandler(this.FrstNameLabel_Click);
            // 
            // RgstrNbrLabel
            // 
            this.RgstrNbrLabel.BackColor = System.Drawing.Color.Transparent;
            this.RgstrNbrLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RgstrNbrLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.RgstrNbrLabel.Location = new System.Drawing.Point(41, 346);
            this.RgstrNbrLabel.Name = "RgstrNbrLabel";
            this.RgstrNbrLabel.Size = new System.Drawing.Size(81, 25);
            this.RgstrNbrLabel.TabIndex = 80;
            this.RgstrNbrLabel.Text = "Matricule";
            this.RgstrNbrLabel.Click += new System.EventHandler(this.RgstrNbrLabel_Click);
            // 
            // NameTxtBx
            // 
            this.NameTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTxtBx.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxtBx.ForeColor = System.Drawing.Color.Chocolate;
            this.NameTxtBx.Location = new System.Drawing.Point(210, 228);
            this.NameTxtBx.Name = "NameTxtBx";
            this.NameTxtBx.Size = new System.Drawing.Size(167, 26);
            this.NameTxtBx.TabIndex = 108;
            this.NameTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameTxtBx.TextChanged += new System.EventHandler(this.NameTxtBx_TextChanged);
            // 
            // FrstNameTxtBx
            // 
            this.FrstNameTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FrstNameTxtBx.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrstNameTxtBx.ForeColor = System.Drawing.Color.Chocolate;
            this.FrstNameTxtBx.Location = new System.Drawing.Point(210, 288);
            this.FrstNameTxtBx.Name = "FrstNameTxtBx";
            this.FrstNameTxtBx.Size = new System.Drawing.Size(167, 26);
            this.FrstNameTxtBx.TabIndex = 109;
            this.FrstNameTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FrstNameTxtBx.TextChanged += new System.EventHandler(this.FrstNameTxtBx_TextChanged);
            // 
            // RgstrNbrTxtBx
            // 
            this.RgstrNbrTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RgstrNbrTxtBx.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RgstrNbrTxtBx.ForeColor = System.Drawing.Color.Chocolate;
            this.RgstrNbrTxtBx.Location = new System.Drawing.Point(210, 347);
            this.RgstrNbrTxtBx.Name = "RgstrNbrTxtBx";
            this.RgstrNbrTxtBx.Size = new System.Drawing.Size(167, 26);
            this.RgstrNbrTxtBx.TabIndex = 110;
            this.RgstrNbrTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RgstrNbrTxtBx.TextChanged += new System.EventHandler(this.RgstrNbrTxtBx_TextChanged);
            // 
            // buttonAddPct
            // 
            this.buttonAddPct.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddPct.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonAddPct.FlatAppearance.BorderSize = 2;
            this.buttonAddPct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAddPct.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonAddPct.Location = new System.Drawing.Point(329, 169);
            this.buttonAddPct.Name = "buttonAddPct";
            this.buttonAddPct.Size = new System.Drawing.Size(48, 29);
            this.buttonAddPct.TabIndex = 111;
            this.buttonAddPct.Text = "+";
            this.buttonAddPct.UseVisualStyleBackColor = false;
            this.buttonAddPct.Click += new System.EventHandler(this.ButtonAddPct_Click);
            // 
            // PrsnPctrBx
            // 
            this.PrsnPctrBx.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PrsnPctrBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrsnPctrBx.Location = new System.Drawing.Point(285, 40);
            this.PrsnPctrBx.Name = "PrsnPctrBx";
            this.PrsnPctrBx.Size = new System.Drawing.Size(120, 123);
            this.PrsnPctrBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PrsnPctrBx.TabIndex = 112;
            this.PrsnPctrBx.TabStop = false;
            // 
            // AddPrsnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 686);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(480, 720);
            this.MinimumSize = new System.Drawing.Size(480, 720);
            this.Name = "AddPrsnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter Un Personne";
            this.Load += new System.EventHandler(this.AddPrsnForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrsnPctrBx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label FrstNameLabel;
        private System.Windows.Forms.Label RgstrNbrLabel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox NameTxtBx;
        private System.Windows.Forms.TextBox FrstNameTxtBx;
        private System.Windows.Forms.TextBox RgstrNbrTxtBx;
        private System.Windows.Forms.Button buttonAddPct;
        private System.Windows.Forms.PictureBox PrsnPctrBx;
    }
}