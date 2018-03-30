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
    public partial class AddDepartment : Form
    {
        public AddDepartment()
        {
            InitializeComponent();
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
                        command.CommandText = string.Format(@"INSERT INTO [dbo].[Department]
           ([ID_Department]
           ,[Name]
           ,[PhoneNumber])
     VALUES
           ('" + t_Id.Text + @"'
           ,'" + t_Name.Text + @"'
           ,'" + t_Tel.Text + @"')");

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
