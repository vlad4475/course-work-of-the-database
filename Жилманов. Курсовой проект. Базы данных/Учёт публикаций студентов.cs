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

namespace Жилманов.Курсовой_проект.Базы_данных
{
    public partial class Учёт_публикаций_студентов : Form
    {
        public Учёт_публикаций_студентов()
        {
            InitializeComponent();

            SqlCommand sql = new SqlCommand("Select [Name] from Graduate", Program.conn);
            using (SqlDataReader dr = sql.ExecuteReader())
            {
                //цикл по всем столбцам полученной в результате запроса таблицы
                while (dr.Read())
                    c_grad.Items.Add(dr.GetValue(0).ToString());
            }
        }

        private void b_select_Click(object sender, EventArgs e)
        {
            int j = 0;
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=VLAD-PK\SQLEXPRESS;Initial Catalog=KursovoyProektZhilmanov;Integrated Security=True"))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = string.Format(@"SELECT Graduate.Name as 'Имя студента', Publication.Name as 'Название публикации', Data as 'Дата' FROM Publication 
JOIN Graduate ON Graduate.ID_Graduate = Publication.ID_Graduate
WHERE Graduate.Name = '" + c_grad.Text +  @"'"); 
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataGridView1.ColumnCount = reader.FieldCount;
                            while (reader.Read())
                            {
                                dataGridView1.RowCount++;
                                for (int i = 0; i < reader.FieldCount; i++)
                                    dataGridView1[i, j].Value = reader[i];
                                j++;
                            }
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                dataGridView1.Columns[i].HeaderText = reader.GetName(i);
                            }
                        }
                    }
                    connection.Close();
                    label2.Text = "Колличество публицаций : " + dataGridView1.RowCount;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }

            
            j = 0;
            dataGridView2.RowCount = 1;
            dataGridView2.ColumnCount = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=VLAD-PK\SQLEXPRESS;Initial Catalog=KursovoyProektZhilmanov;Integrated Security=True"))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = string.Format(@"SELECT Graduate.Name as 'Имя студента', Speech.Name as 'Название публикации', Speech.Theme as 'Тема', Data as 'Дата' FROM Speech 
JOIN Graduate ON Graduate.ID_Graduate = Speech.ID_Graduate
WHERE Graduate.Name = '" + c_grad.Text + @"'");
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataGridView2.ColumnCount = reader.FieldCount;
                            while (reader.Read())
                            {
                                dataGridView2.ColumnCount = reader.FieldCount;
                                dataGridView2.RowCount++;
                                for (int i = 0; i < reader.FieldCount; i++)
                                    dataGridView2[i, j].Value = reader[i];
                                j++;
                            }

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                dataGridView2.Columns[i].HeaderText = reader.GetName(i);
                            }
                        }
                    }
                    connection.Close();
                    label3.Text = "Участий в конференциях : " + dataGridView2.RowCount;
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка" + ex.Message);
            }

            return;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void c_grad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
