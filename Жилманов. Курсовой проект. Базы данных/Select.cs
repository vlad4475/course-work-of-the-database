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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {             
           // this.departmentTableAdapter.Fill(this.kursovoyProektZhilmanovDataSet.Department);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void b_change_Click(object sender, EventArgs e)
        {
            /*this.departmentBindingSource.DataMember = "ScientificGroup";
            this.departmentBindingSource.DataSource = this.kursovoyProektZhilmanovDataSet;
            this.scientificGroupTableAdapter.Fill(this.kursovoyProektZhilmanovDataSet.ScientificGroup);*/

            try
            {
                SqlCommand sql = new SqlCommand(@"Select * from Студент");

                SqlParameter Napr = new SqlParameter();
                Napr.ParameterName = "@Napr";
                Napr.SqlDbType = SqlDbType.NChar;
              //  Napr.Value = comboBox1.SelectedItem.ToString();
                sql.Parameters.Add(Napr);

                dataGridView1.ClearSelection();
                dataGridView1.RowCount = 1;
                using (SqlDataReader dr = sql.ExecuteReader())
                {
                    dataGridView1.ColumnCount = dr.FieldCount;

                    //цикл по всем столбцам полученной в результате запроса таблицы
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        dataGridView1.Rows[0].Cells[i].Value = dr.GetName(i).ToString();
                    }
                    /*метод GetName() класса SqlDataReader позволяет получить имя столбца
                    по номеру, который передается в качестве параметра, данному методу
                    и озночает номер столбца в таблице(начинается с 0)
                    */
                    int ngr = 0;
                    while (dr.Read())
                    {
                        dataGridView1.RowCount++;
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[i].Value = dr.GetValue(i).ToString();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e) //C:\\Users\\vlad\\Desktop\\7sem\\Базы данных\\Курсач Жилманов\\KursovoyProektZhilmanov.mdf
        {
            // Server=.\SQLExpress;AttachDbFilename=C:\MyFolder\MyDataFile.mdf;Database=dbname;
            //Trusted_Connection = Yes;
            string temp = "";
            int j = 0;
            dataGridView2.RowCount = 1;
            dataGridView2.ColumnCount = 0;

            using (SqlConnection connection = new SqlConnection(@"Data Source=VLAD-PK\SQLEXPRESS;Initial Catalog=KursovoyProektZhilmanov;Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = string.Format("SELECT * FROM " + comboBox1.Text);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataGridView2.ColumnCount = reader.FieldCount;
                        while (reader.Read())
                        {
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
                return;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
