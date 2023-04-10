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

namespace Effectif_APP_1._1._002
{
    public partial class OfficierForm : Form
    {
        public OfficierForm()
        {
            InitializeComponent();
        }

        //Data Base Connection.
        SqlConnection Conec = new SqlConnection(@"Data Source=KADYY-PC\SQLEXPRESS;Initial Catalog=EffectifAppDb1.1.002;Integrated Security=True");

        private void OfficierForm_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        public void ShowList()
        {
            try
            {
                Conec.Open();
                String MyQuery = "select * from OffTblDb";
                SqlDataAdapter sqladptr = new SqlDataAdapter(MyQuery, Conec);
                SqlCommandBuilder sqlbldr = new SqlCommandBuilder(sqladptr);
                var dtset = new DataSet();
                sqladptr.Fill(dtset);
                LstOffDataGridView.DataSource = dtset.Tables[0];
                Conec.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }
        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LstOffDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            using (AddPrsnForm AddFrm = new AddPrsnForm())
            {
                AddFrm.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void DtGrdTblPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez Vous Supprimer Ce Elément", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int Officierid = Convert.ToInt32(LstOffDataGridView.SelectedRows[0].Cells["Matricule"].FormattedValue.ToString());
                    Conec.Open();
                    String MyQuery = "delete from OffTblDb where Matricule ='" + Officierid + "';";
                    SqlCommand sqlcmnd = new SqlCommand(MyQuery, Conec);
                    sqlcmnd.ExecuteNonQuery();
                    Conec.Close();
                    this.OnLoad(e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
    }
}

