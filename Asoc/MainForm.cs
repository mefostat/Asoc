using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        // Добавить проверку вводимых данныъ - возможна реализация через регулярки (Прочитать о них) 
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
    }
}
