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
                // Обновляем данные в DateGrid
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
                // Обновляем данные в DateGrid
                globalClass.LoadData("cartridge_type");
                viewTable.DataSource = globalClass.bindingsource;

            }
            else if(rdbWorkT.Checked)
            {
                try
                {
                    globalClass.AddType(TextName.Text);

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
                // Обновляем данные в DateGrid
                globalClass.LoadData("work_type");
                viewTable.DataSource = globalClass.bindingsource;
            }
            
        }

        private void AddOrg_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            // Обновляем данные в DateGrid
            UpdateElement();


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
            // Меняем позиции элементов
            lblNameOrg.Location = new Point(8, 28); 
            lblUpr.Location = new Point(58, 57);

            VisibleElement(true);

            globalClass.LoadData("organizations");
            viewTable.DataSource = globalClass.bindingsource;
        }

        private void rbtnCart_CheckedChanged(object sender, EventArgs e)
        { 
            lblNameOrg.Text = "Наименование типа:";
            lblUpr.Text = "Расходники:";
            lblAddress.Text = "Тонер:";
            VisibleElement(true);
            // Меняем позиции элементов
            lblNameOrg.Location = new Point(75, 28);
            lblUpr.Location = new Point(138,57 );

            // Обновляем данные в DateGrid
            globalClass.LoadData("cartridge_type");
            viewTable.DataSource = globalClass.bindingsource;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblNameOrg.Text = "Наименование типа:";
            VisibleElement(false);

            // Обновляем данные в DateGrid
            globalClass.LoadData("work_type");
            viewTable.DataSource = globalClass.bindingsource;
        }

        /// Метод появления 
        public void VisibleElement(bool ans)
        {
            if (ans)
            {
                lblUpr.Visible = true;
                lblAddress.Visible = true;
                TextAddress.Visible = true;
                textUniquePr.Visible = true;
            }
            else
            {
                lblUpr.Visible = false;
                lblAddress.Visible = false;
                TextAddress.Visible = false;
                textUniquePr.Visible = false;
            }
        }

        // Метод обновления 
        public void UpdateElement()
        {
            globalClass.LoadData("organizations");
            boxOrg.DataSource = globalClass.bindingsource;
            boxOrg.DisplayMember = "name_org";
            boxOrg.ValueMember = "id_org";

            globalClass.LoadData("cartridge_type");
            boxType.DataSource = globalClass.bindingsource;
            boxType.DisplayMember = "cartridge_name";
            //boxType.ValueMember = "id_cartridge";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           BarcodePic.Image =  globalClass.GeneratedBarcode(BarcodePic.Image, globalClass.GenerateId("SUK","825", Convert.ToString(Properties.Settings.Default.CountCart)));
            Properties.Settings.Default.CountCart++; 
        }

        private void boxOrg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            UpdateElement();
        }
    }
}
