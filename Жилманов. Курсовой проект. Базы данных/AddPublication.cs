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
    public partial class AddPublication : Form
    {
        public AddPublication()
        {
            InitializeComponent();

            SqlCommand sql = new SqlCommand("Select [Name] from Graduate", Program.conn);

            using (SqlDataReader dr = sql.ExecuteReader())
            {
                //цикл по всем столбцам полученной в результате запроса таблицы
                while (dr.Read())
                    c_grad.Items.Add(dr.GetValue(0).ToString());
            }

            sql = new SqlCommand("Select [Name] from Adviser", Program.conn);

            using (SqlDataReader dr = sql.ExecuteReader())
            {
                //цикл по всем столбцам полученной в результате запроса таблицы
                while (dr.Read())
                    c_advis.Items.Add(dr.GetValue(0).ToString());
            }


        }

        private void b_add_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=VLAD-PK\SQLEXPRESS;Initial Catalog=KursovoyProektZhilmanov;Integrated Security=True"))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = string.Format(@"INSERT INTO [dbo].[Publication]
           ([ID_Publication]
           ,[Name]
           ,[Theme]
           ,[Data]
           ,[ID_Adviser]
           ,[ID_Graduate])
     VALUES
           ('" + t_Id.Text + @"'
           ,'" + t_Name.Text + @"'
           ,'" + t_teme.Text + @"'
           ," + t_Date.Text + @"
           ," + c_advis.SelectedIndex + @"
           ," + c_grad.SelectedIndex + @")");

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Запись добавлена");
                }
            }
            catch(Exception exede)
            {
                MessageBox.Show("Ошибка при добавлении. " + exede.Message);
            }
        }
    }
}
