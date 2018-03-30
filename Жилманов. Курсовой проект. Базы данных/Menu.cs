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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void b_Select_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            AddPanel f1 = new AddPanel();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Запросы f = new Запросы();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateDelete f = new UpdateDelete();
            f.Show();
        }
    }
}
