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
    public partial class Список_учасников_конференций : Form
    {
        public Список_учасников_конференций()
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

            String qwery = @"SELECT Graduate.Name as 'ФИО', Speech.Name as 'Назвение', Speech.Theme as 'Тема', Adviser.Name as 'Руководитель', Data as 'Дата'  From Speech
JOIN Graduate ON Speech.ID_Graduate = Graduate.ID_Graduate
JOIN Adviser ON  Adviser.ID_Adviser = Graduate.ID_Adviser
WHERE (1 > 0) ";

            if (cb_theme.Checked)
                qwery += " AND ('" + t_theme.Text + "' = Speech.Theme) ";

            if (cb_adv.Checked)
                qwery += " AND ('" + c_adv.Text + "' = Adviser.Name) ";

            if (cb_year.Checked)
                qwery += " AND (Speech.Data BETWEEN '" + t_startYear.Text + "' AND '" + t_endYear.Text + "') ";

            try
            {
                using (SqlCommand command = Program.conn.CreateCommand())
                {
                    command.CommandText = string.Format(qwery);
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
                          
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка" + ex.Message);
            }
            return;
        }
    }
}
