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
    public partial class AddSpeech : Form
    {
        public AddSpeech()
        {
            InitializeComponent();

            SqlCommand sql = new SqlCommand("Select [Name] from Conference", Program.conn);

            using (SqlDataReader dr = sql.ExecuteReader())
            {
                //цикл по всем столбцам полученной в результате запроса таблицы
                while (dr.Read())
                    c_conf.Items.Add(dr.GetValue(0).ToString());
            }

            sql = new SqlCommand("Select [Name] from Graduate", Program.conn);

            using (SqlDataReader dr = sql.ExecuteReader())
            {
                //цикл по всем столбцам полученной в результате запроса таблицы
                while (dr.Read())
                    c_grad.Items.Add(dr.GetValue(0).ToString());
            }
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=VLAD-PK\SQLEXPRESS;Initial Catalog=KursovoyProektZhilmanov;Integrated Security=True"))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = string.Format(@"INSERT INTO [dbo].[Speech]
           ([ID_Speech]
           ,[Name]
           ,[Theme]
           ,[Data]
           ,[ID_Graduate]
           ,[ID_Conference])
     VALUES
           ('" + t_id.Text + @"'
           ,'" + t_name.Text + @"'
           ,'" + t_teme.Text + @"'
           ,'" + t_date.Text + @"'
           ,'" + c_grad.SelectedIndex + @"'
           ,'" + c_conf.SelectedIndex + @"')");

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Запись добавлена");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении.");
            }
        }
    }
}
