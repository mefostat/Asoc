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
                   
                }
             

            }
            catch(Exception error)
            {
                System.Windows.Forms.MessageBox.Show(error.ToString());
            }
        }




    }


    class Organizations
    {
        int id;
        string name_org, address, unique_prefix;
        void organizations(string nameOrg, string addressOrg, string uniquePrefix) // Конструктор класс organizations
        {
            this.name_org = nameOrg;
            this.address = addressOrg;
            this.unique_prefix = uniquePrefix;
        }

    }
}
