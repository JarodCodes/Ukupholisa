using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukupholisa
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CallCentre.Presentation_Layer.OperatorUI callcenter = new CallCentre.Presentation_Layer.OperatorUI();
            callcenter.Show();
            this.Hide();
        }

        private void btnMedicalDept_Click(object sender, EventArgs e)
        {
            Medical_Department.Medical_Dept meddept = new Medical_Department.Medical_Dept();
            meddept.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Provider_Management.Presentation_Layer.ProviderManagement provdept = new Provider_Management.Presentation_Layer.ProviderManagement();
            provdept.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CallCentre.Presentation_Layer.CleintAndPolicy clientPol = new CallCentre.Presentation_Layer.CleintAndPolicy();
            clientPol.Show();
            this.Hide();
        }
    }
}
