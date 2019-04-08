using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Asoc
{
    class Global
    {
        string ConnectionString = @"server=localhost;user id=root;password=root;database=asoc_db";

        public void ConnectionTest() // Тестовое подключение для проверки соединения с бд
        {
            try { 

             using(MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command;
                }
             

            }
            catch(Exception error)
            {
                System.Windows.Forms.MessageBox.Show(error.ToString());
            }
        }
    }
}
