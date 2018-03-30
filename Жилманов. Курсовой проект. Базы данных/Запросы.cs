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
    public partial class Запросы : Form
    {
        public Запросы()
        {
            InitializeComponent();
        }

        private void b_gradByYears_Click(object sender, EventArgs e)
        {
            Аспиранты_по_годам_обучения f = new Аспиранты_по_годам_обучения();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Аспиранты_по_научным_руководителям f = new Аспиранты_по_научным_руководителям();
            f.Show();
        }

        private void b_GradByYear_Click(object sender, EventArgs e)
        {
            Аспиранты_по_годам_обучения f = new Аспиранты_по_годам_обучения();
            f.Show();
        }

        private void b_publisher_Click(object sender, EventArgs e)
        {
            Учёт_публикаций_студентов f = new Учёт_публикаций_студентов();
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Учёт_публикаций_преподавателей f = new Учёт_публикаций_преподавателей();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Список_учасников_конференций f = new Список_учасников_конференций();
            f.Show();
        }
    }
}
