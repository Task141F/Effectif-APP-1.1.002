using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Effectif_APP_1._1._002
{
    public partial class AddPrsnForm : Form
    {
        public AddPrsnForm()
        {
            InitializeComponent();
        }

        //Data Base Connection.
        SqlConnection Con = new SqlConnection(@"Data Source=KADYY-PC\SQLEXPRESS;Initial Catalog=EffectifAppDb1.1.002;Integrated Security=True");

        private void AddPrsnForm_Load(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }


        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                InsertValues();
                this.Dispose();
            }
        }

        private void InsertValues()
        {
            DialogResult dialogResult = MessageBox.Show("Voulez Vous Ajouter Ce Element", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Con.Open();
                    SqlCommand sqlcmnd = new SqlCommand("insert into OffTblDb values('" + RgstrNbrTxtBx.Text + "','" + NameTxtBx.Text + "','" + FrstNameTxtBx.Text + "')", Con);
                    sqlcmnd.ExecuteNonQuery();
                    /*if (!Directory.Exists("img"))
                        Directory.CreateDirectory("img");
                    PrsnPctrBx.Image.Save("img/" + RgstrNbrTxtBx.Text + ".jpg");*/
                    Con.Close();
                    //PrsnPctrBx.Image = new PictureBox().Image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                this.Dispose();
            }
        }

        private bool IsFormValid()
        {
            if (NameTxtBx.Text.Trim() == string.Empty
                || FrstNameTxtBx.Text.Trim() == string.Empty
                || RgstrNbrTxtBx.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Fill Fields", "Fields Are Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void NameTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void FrstNameTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void RgstrNbrLabel_Click(object sender, EventArgs e)
        {

        }

        private void RgstrNbrTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAddPct_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpnFlDlg = new OpenFileDialog
            {
                Filter = "Images|*.jpg;*.png;*.gif;*.bmp",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            };
            if (OpnFlDlg.ShowDialog() == DialogResult.OK)
            {
                PrsnPctrBx.Image = Image.FromFile(OpnFlDlg.FileName); 
            }
        }
    }
}
