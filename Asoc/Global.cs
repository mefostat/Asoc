using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Asoc
{
    class Global
    {
        /// Список таблиц 
        /// cartridge_type execute_work in_serving organizations work_type
        public BindingSource bindingsource;
        public string ConnectionString = @"server=localhost;user id=root;password=root;database=asoc_db"; // строка подключения

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

        public void DeleteObject(int id,string NameTable) // метод удаления данных
        {
            string stringQuery = @"DELETE FROM "+ NameTable + " WHERE id = " + id.ToString();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(stringQuery, connection);
                command.ExecuteNonQuery();
            }
        }

        public void LoadData(string NameTable) // Метод выборки данных 
        {
            string SqlQuery = "SELECT * FROM "+NameTable;
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(SqlQuery, connection);
                

                command.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(SqlQuery,connection);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                DataTable table = new DataTable();
                adapter.Fill(table);
                bindingsource = new BindingSource();
                bindingsource.DataSource = table;
                
            }
        }
    }


    class Organizations:Global
    {
        int id;
        string name_org, address, unique_prefix;
        public Organizations(string nameOrg, string addressOrg, string uniquePrefix) // Конструктор класса organizations
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

    class CartridgeType:Global
    {
        int id_cartridg;
        string cartridg_name, consumables, toner;
        public CartridgeType(string Cartridg_name, string Consumables, string Toner)
        {
            this.cartridg_name = Cartridg_name;
            this.consumables = Consumables;
            this.toner = Toner;
        }

        // Добавление вида картриджа
        public void AddCartridgType()
        {
            string StringSql = "INSERT INTO `asoc_db`.`cartridge_type` (`cartridge_name`,`consumables`,`toner`) VALUES (@cartridge_name,@consumables,@toner)";

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(StringSql, connection);

                MySqlParameter nameParam = new MySqlParameter("@cartridge_name",cartridg_name);
                command.Parameters.Add(nameParam);

                MySqlParameter cnsmParam = new MySqlParameter("@consumables",consumables);
                command.Parameters.Add(cnsmParam);

                MySqlParameter tonerParam = new MySqlParameter("@toner",toner);
                command.Parameters.Add(tonerParam);

                command.ExecuteNonQuery();

            }
        }
    }

}
