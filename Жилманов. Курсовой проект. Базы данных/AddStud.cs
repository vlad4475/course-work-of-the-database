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
    public partial class AddStud : Form
    {
        public AddStud()
        {
            InitializeComponent();

            c_sex.Items.Add("M");
            c_sex.Items.Add("F");

            SqlCommand sql = new SqlCommand("Select [Name] from Department", Program.conn);

            using (SqlDataReader dr = sql.ExecuteReader())
            {
                //цикл по всем столбцам полученной в результате запроса таблицы
                while (dr.Read())
                    c_dep.Items.Add(dr.GetValue(0).ToString());
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
                        command.CommandText = string.Format(@"INSERT INTO [dbo].[Student]
           ([ID_Student]
           ,[Name]
           ,[PhoneNumber]
           ,[Sx]
           ,[ID_Department])
     VALUES
           ('" + t_id.Text + @"'
           ,'" + t_Name.Text + @"'
           ,'" + t_Phone.Text + @"'
           ,'" + c_sex.Text + @"'
           ,'" + c_dep.SelectedIndex + @"')");

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
