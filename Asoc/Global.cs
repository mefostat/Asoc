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
        public string ConnectionString = @"server=localhost;user id=root;password=root;database=asoc_db";

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


    class Organizations:Global
    {
        int id;
        string name_org, address, unique_prefix;
        public Organizations(string nameOrg, string addressOrg, string uniquePrefix) // Конструктор класс organizations
        {
            this.name_org = nameOrg;
            this.address = addressOrg;
            this.unique_prefix = uniquePrefix;
        }

        // Функция добавления организации
        public void AddOrganizations() 
        {
            string SqlQuery = "INSERT INTO organizations (name_org,address,unique_prefix) VALUES (@name_org,@address,@unique_prefix)";
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(SqlQuery, connection);
                MySqlParameter nameOrgParam = new MySqlParameter("@name_org", name_org);

                command.Parameters.Add(nameOrgParam);

                MySqlParameter addressOrgParam = new MySqlParameter("@address",address);

                command.Parameters.Add(addressOrgParam);

                MySqlParameter uniprParam = new MySqlParameter("@unique_prefix", unique_prefix);

                command.Parameters.Add(uniprParam);

                command.ExecuteNonQuery();
            }
        }

    }
}
