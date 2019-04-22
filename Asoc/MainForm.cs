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
            if(rbtnOrg.Checked)
            {
                try
                { // Ловим исключения если были введены некорректные данные
                    NameOrg = TextName.Text;
                    Address = TextAddress.Text;
                    UniPrefix = textUniquePr.Text;

                    // Создаем класс, передаем конструктору значения 
                    Organizations organizations = new Organizations(NameOrg, Address, UniPrefix);
                    organizations.AddOrganizations(); // Добавляем данные об организации в бд
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }

                globalClass.LoadData("organizations");
                viewTable.DataSource = globalClass.bindingsource;
            }
            else if(rbtnCart.Checked) 
            {
                try
                {
                    CartridgeType cartridgetype = new CartridgeType(TextName.Text, textUniquePr.Text, TextAddress.Text);
                    cartridgetype.AddCartridgType();

                }
                catch(Exception error)
                {
                    MessageBox.Show(error.ToString());
                }

                globalClass.LoadData("cartridge_type");
                viewTable.DataSource = globalClass.bindingsource;

            }
            
        }

        private void AddOrg_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            globalClass.LoadData("organizations");
            viewTable.DataSource = globalClass.bindingsource;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void viewOrg_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void rbtnOrg_CheckedChanged(object sender, EventArgs e)
        {
            lblNameOrg.Text = "Наименования организации:";
            lblUpr.Text = "Уникальный префикс:";
            lblAddress.Text = "Адрес:";
            lblNameOrg.Location = new Point(8, 28);
            lblUpr.Location = new Point(58, 57);

            globalClass.LoadData("organizations");
            viewTable.DataSource = globalClass.bindingsource;
        }

        private void rbtnCart_CheckedChanged(object sender, EventArgs e)
        {
            lblNameOrg.Text = "Наименование типа:";
            lblUpr.Text = "Расходники:";
            lblAddress.Text = "Тонер:";

            lblNameOrg.Location = new Point(75, 28);
            lblUpr.Location = new Point(138,57 );
            globalClass.LoadData("cartridge_type");
            viewTable.DataSource = globalClass.bindingsource;
        }
    }
}
