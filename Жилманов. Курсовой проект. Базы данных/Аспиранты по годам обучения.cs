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
    public partial class Аспиранты_по_годам_обучения : Form
    {
        public Аспиранты_по_годам_обучения()
        {
            InitializeComponent();
        }

        private void b_select_Click(object sender, EventArgs e)
        {
            // Server=.\SQLExpress;AttachDbFilename=C:\MyFolder\MyDataFile.mdf;Database=dbname;
            //Trusted_Connection = Yes;
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
                        command.CommandText = string.Format("SELECT Name, PhoneNumber, YearAdmis FROM Graduate WHERE YearAdmis BETWEEN '" + t_startYear.Text + @"' AND '" + t_endYear.Text + @"'"); //SELECT * FROM Department
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
