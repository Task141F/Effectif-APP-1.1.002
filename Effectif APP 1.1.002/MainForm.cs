using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Effectif_APP_1._1._002
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Toppanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopPanelText_Click(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OffFrmBtn_Click(object sender, EventArgs e)
        {
            OfficierForm OpnOffiForm = new OfficierForm();
            OpnOffiForm.Show();
        }

        private void SoffFrmBtn_Click(object sender, EventArgs e)
        {
            SousOfficierForm OpnSoffiForm = new SousOfficierForm();
            OpnSoffiForm.Show();
        }

        private void HdrFrmBtn_Click(object sender, EventArgs e)
        {
            HdrForm OpnHdrForm = new HdrForm();
            OpnHdrForm.Show();
        }

        private void LstGlbFrmBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
