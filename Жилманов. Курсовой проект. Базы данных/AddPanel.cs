using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Жилманов.Курсовой_проект.Базы_данных
{
    public partial class AddPanel : Form
    {
        public AddPanel()
        {
            InitializeComponent();
        }

        private void b_addScientificGroup_Click(object sender, EventArgs e)
        {
            AddScientificGroup f = new AddScientificGroup();
            f.Show();
        }

        private void b_addDepartment_Click(object sender, EventArgs e)
        {
            AddDepartment f = new AddDepartment();
            f.Show();
        }

        private void b_addAdviser_Click(object sender, EventArgs e)
        {
            AddAdviser f = new AddAdviser();
            f.Show();
        }

        private void b_addGrad_Click(object sender, EventArgs e)
        {
            AddGraduate f = new AddGraduate();
            f.Show();
        }

        private void b_addConf_Click(object sender, EventArgs e)
        {
            AddConference f = new AddConference();
            f.Show();
        }

        private void b_addSpeech_Click(object sender, EventArgs e)
        {
            AddSpeech f = new AddSpeech();
            f.Show();
        }

        private void b_addPubl_Click(object sender, EventArgs e)
        {
            AddPublication f = new AddPublication();
            f.Show();
        }

        private void b_addStud_Click(object sender, EventArgs e)
        {
            AddStud f = new AddStud();
            f.Show();
        }
    }
}
