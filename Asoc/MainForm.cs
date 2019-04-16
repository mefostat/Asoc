using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Asoc
{
    public partial class MainForm : Form
    {
        Global globalClass = new Global();
        public MainForm()
        {
            InitializeComponent();
            globalClass.ConnectionTest();

        }

        // TODO : Добавить проверку существующих данных
        // Добавить проверку вводимых данных - возможна реализация через регулярки (Прочитать о них) 
        // Создать остальные необходимые сущности 
        private void btnAddOrganization_Click(object sender, EventArgs e)
        {
            string NameOrg, Address, UniPrefix;

            try { // Ловим исключения если были введены некорректные данные
            NameOrg = TextNameOrg.Text;
            Address = TextAddress.Text;
            UniPrefix = textUniquePr.Text;
               
                // Создаем класс, передаем конструктору значения 
                Organizations organizations = new Organizations(NameOrg, Address, UniPrefix);
                organizations.AddOrganizations(); // Добавляем данные об организации в бд
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }

            
        }

        private void AddOrg_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            v

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
