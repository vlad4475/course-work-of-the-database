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
    public partial class Учёт_публикаций_преподавателей : Form
    {
        public Учёт_публикаций_преподавателей()
        {
            InitializeComponent();

            SqlCommand sql = new SqlCommand("Select [Name] from Adviser", Program.conn);
            using (SqlDataReader dr = sql.ExecuteReader())
            {
                //цикл по всем столбцам полученной в результате запроса таблицы
                while (dr.Read())
                    c_adv.Items.Add(dr.GetValue(0).ToString());
            }
        }

        private void b_select_Click(object sender, EventArgs e)
        {
            string temp = "";
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
                        command.CommandText = string.Format(@"SELECT Adviser.Name as 'Имя студента', Publication.Name as 'Название публикации', Data as 'Дата' FROM Publication 
JOIN Adviser ON Adviser.ID_Adviser = Publication.ID_Adviser
WHERE Adviser.Name = '" + c_adv.Text + @"'");
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
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка" + ex.Message);
            }


            

            return;
        }
    }
}
