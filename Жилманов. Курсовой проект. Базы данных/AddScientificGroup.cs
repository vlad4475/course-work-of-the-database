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
using System.Data.SqlClient;

namespace Жилманов.Курсовой_проект.Базы_данных
{
    public partial class AddScientificGroup : Form
    {
        public AddScientificGroup()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {

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
                        command.CommandText = string.Format(@"INSERT INTO [dbo].[ScientificGroup]
           ([ID_ScientificGroup]
           ,[Name]
           ,[LectureHall])
     VALUES
           ('" + t_id.Text + @"'
           ,'" + t_Name.Text + @"'
           ,'" + t_hall.Text + @"'
)");

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
