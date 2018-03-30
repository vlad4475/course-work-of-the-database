using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Жилманов.Курсовой_проект.Базы_данных
{
    public partial class Аспиранты_по_научным_руководителям : Form
    {
        public Аспиранты_по_научным_руководителям()
        {
            InitializeComponent();

            SqlCommand sql = new SqlCommand("Select [Name] from Adviser", Program.conn);

            using (SqlDataReader dr = sql.ExecuteReader())
            {
                //цикл по всем столбцам полученной в результате запроса таблицы
                while (dr.Read())
                    c_NameAdvis.Items.Add(dr.GetValue(0).ToString());
            }
        }

        private void t_Select_Click(object sender, EventArgs e)
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
                        command.CommandText = string.Format("EXECUTE gradByAdvisor @AdvisorName = '" + c_NameAdvis.Text + @"'"); //SELECT * FROM Department
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
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
