namespace Effectif_APP_1._1._002
{
    partial class OfficierForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.RgstrNbrTxtBx = new Guna.UI2.WinForms.Guna2TextBox();
            this.DtGrdTblPanel = new System.Windows.Forms.Panel();
            this.LstOffDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.OffMatriculeLabel = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.DtGrdTblPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LstOffDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.MainPanel.Controls.Add(this.RgstrNbrTxtBx);
            this.MainPanel.Controls.Add(this.DtGrdTblPanel);
            this.MainPanel.Controls.Add(this.buttonSearch);
            this.MainPanel.Controls.Add(this.OffMatriculeLabel);
            this.MainPanel.Controls.Add(this.buttonAdd);
            this.MainPanel.Controls.Add(this.buttonPrint);
            this.MainPanel.Controls.Add(this.buttonEdit);
            this.MainPanel.Controls.Add(this.buttonView);
            this.MainPanel.Controls.Add(this.buttonDelete);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1264, 682);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // RgstrNbrTxtBx
            // 
            this.RgstrNbrTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RgstrNbrTxtBx.BorderColor = System.Drawing.Color.Chocolate;
            this.RgstrNbrTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RgstrNbrTxtBx.DefaultText = "";
            this.RgstrNbrTxtBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RgstrNbrTxtBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RgstrNbrTxtBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RgstrNbrTxtBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RgstrNbrTxtBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RgstrNbrTxtBx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RgstrNbrTxtBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RgstrNbrTxtBx.Location = new System.Drawing.Point(937, 20);
            this.RgstrNbrTxtBx.Name = "RgstrNbrTxtBx";
            this.RgstrNbrTxtBx.PasswordChar = '\0';
            this.RgstrNbrTxtBx.PlaceholderText = "";
            this.RgstrNbrTxtBx.SelectedText = "";
            this.RgstrNbrTxtBx.Size = new System.Drawing.Size(167, 29);
            this.RgstrNbrTxtBx.TabIndex = 104;
            // 
            // DtGrdTblPanel
            // 
            this.DtGrdTblPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtGrdTblPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DtGrdTblPanel.Controls.Add(this.LstOffDataGridView);
            this.DtGrdTblPanel.Location = new System.Drawing.Point(11, 100);
            this.DtGrdTblPanel.Name = "DtGrdTblPanel";
            this.DtGrdTblPanel.Padding = new System.Windows.Forms.Padding(3);
            this.DtGrdTblPanel.Size = new System.Drawing.Size(1242, 570);
            this.DtGrdTblPanel.TabIndex = 103;
            this.DtGrdTblPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DtGrdTblPanel_Paint);
            // 
            // LstOffDataGridView
            // 
            this.LstOffDataGridView.AllowUserToAddRows = false;
            this.LstOffDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.LstOffDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.LstOffDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LstOffDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.LstOffDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstOffDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LstOffDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LstOffDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.LstOffDataGridView.ColumnHeadersHeight = 40;
            this.LstOffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LstOffDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.LstOffDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstOffDataGridView.EnableHeadersVisualStyles = false;
            this.LstOffDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.LstOffDataGridView.Location = new System.Drawing.Point(3, 3);
            this.LstOffDataGridView.MultiSelect = false;
            this.LstOffDataGridView.Name = "LstOffDataGridView";
            this.LstOffDataGridView.RowHeadersVisible = false;
            this.LstOffDataGridView.RowTemplate.Height = 30;
            this.LstOffDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LstOffDataGridView.Size = new System.Drawing.Size(1236, 564);
            this.LstOffDataGridView.TabIndex = 71;
            this.LstOffDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.LstOffDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.LstOffDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstOffDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.LstOffDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.LstOffDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.LstOffDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.LstOffDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.LstOffDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.LstOffDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.LstOffDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.LstOffDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.LstOffDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.LstOffDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.LstOffDataGridView.ThemeStyle.ReadOnly = false;
            this.LstOffDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.LstOffDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LstOffDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.LstOffDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.LstOffDataGridView.ThemeStyle.RowsStyle.Height = 30;
            this.LstOffDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.LstOffDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.LstOffDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LstOffDataGridView_CellContentClick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonSearch.FlatAppearance.BorderSize = 2;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonSearch.Location = new System.Drawing.Point(1110, 20);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(141, 29);
            this.buttonSearch.TabIndex = 102;
            this.buttonSearch.Text = "RECHERCHER";
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // OffMatriculeLabel
            // 
            this.OffMatriculeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OffMatriculeLabel.BackColor = System.Drawing.Color.Transparent;
            this.OffMatriculeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.OffMatriculeLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.OffMatriculeLabel.Location = new System.Drawing.Point(823, 22);
            this.OffMatriculeLabel.Name = "OffMatriculeLabel";
            this.OffMatriculeLabel.Size = new System.Drawing.Size(108, 29);
            this.OffMatriculeLabel.TabIndex = 101;
            this.OffMatriculeLabel.Text = "MATRICULE";
            this.OffMatriculeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonAdd.Location = new System.Drawing.Point(12, 22);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 29);
            this.buttonAdd.TabIndex = 96;
            this.buttonAdd.Text = "AJOUTER";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrint.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonPrint.FlatAppearance.BorderSize = 2;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPrint.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonPrint.Location = new System.Drawing.Point(515, 22);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(108, 29);
            this.buttonPrint.TabIndex = 100;
            this.buttonPrint.Text = "IMPRIMER";
            this.buttonPrint.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonEdit.FlatAppearance.BorderSize = 2;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonEdit.Location = new System.Drawing.Point(129, 22);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 29);
            this.buttonEdit.TabIndex = 97;
            this.buttonEdit.Text = "MODIFIER";
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonView
            // 
            this.buttonView.BackColor = System.Drawing.Color.Transparent;
            this.buttonView.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonView.FlatAppearance.BorderSize = 2;
            this.buttonView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonView.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonView.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonView.Location = new System.Drawing.Point(388, 22);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(109, 29);
            this.buttonView.TabIndex = 99;
            this.buttonView.Text = "AFFICHER";
            this.buttonView.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonDelete.FlatAppearance.BorderSize = 2;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonDelete.Location = new System.Drawing.Point(243, 22);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(126, 29);
            this.buttonDelete.TabIndex = 98;
            this.buttonDelete.Text = "SUPPRIMER";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // OfficierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.MainPanel);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "OfficierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste Des Officiers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OfficierForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.DtGrdTblPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LstOffDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label OffMatriculeLabel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel DtGrdTblPanel;
        public Guna.UI2.WinForms.Guna2DataGridView LstOffDataGridView;
        private Guna.UI2.WinForms.Guna2TextBox RgstrNbrTxtBx;
    }
}