using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Жилманов.Курсовой_проект.Базы_данных
{
    static public class Program
    {
        public static SqlConnection conn;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            conn = new SqlConnection(@"Data Source=VLAD-PK\SQLEXPRESS;Initial Catalog=KursovoyProektZhilmanov;Integrated Security=True");
            try
            {
                //пробуем подключится
                conn.Open();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
                MessageBox.Show("Не удалось подключиться к базе данных. Тут приложение нужно завершить, но можно потыкать меню чисто для ознакомления.");
            }
            Application.Run(new Menu());
        }
    }
}
