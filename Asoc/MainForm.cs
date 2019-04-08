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

        private void btnAddOrganization_Click(object sender, EventArgs e)
        {

        }
    }
}
