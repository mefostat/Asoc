namespace Asoc
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AddOrg = new System.Windows.Forms.TabPage();
            this.rbtnCart = new System.Windows.Forms.RadioButton();
            this.rbtnOrg = new System.Windows.Forms.RadioButton();
            this.viewTable = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.TextAddress = new System.Windows.Forms.TextBox();
            this.textUniquePr = new System.Windows.Forms.TextBox();
            this.TextName = new System.Windows.Forms.TextBox();
            this.lblUpr = new System.Windows.Forms.Label();
            this.lblNameOrg = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.rdbWorkT = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BarcodePic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxOrg = new System.Windows.Forms.ComboBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.boxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddOrg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewTable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePic)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(658, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Просмотр";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AddOrg
            // 
            this.AddOrg.BackColor = System.Drawing.Color.Gainsboro;
            this.AddOrg.Controls.Add(this.rdbWorkT);
            this.AddOrg.Controls.Add(this.rbtnCart);
            this.AddOrg.Controls.Add(this.rbtnOrg);
            this.AddOrg.Controls.Add(this.viewTable);
            this.AddOrg.Controls.Add(this.btnAdd);
            this.AddOrg.Controls.Add(this.lblAddress);
            this.AddOrg.Controls.Add(this.TextAddress);
            this.AddOrg.Controls.Add(this.textUniquePr);
            this.AddOrg.Controls.Add(this.TextName);
            this.AddOrg.Controls.Add(this.lblUpr);
            this.AddOrg.Controls.Add(this.lblNameOrg);
            this.AddOrg.Location = new System.Drawing.Point(4, 22);
            this.AddOrg.Name = "AddOrg";
            this.AddOrg.Padding = new System.Windows.Forms.Padding(3);
            this.AddOrg.Size = new System.Drawing.Size(658, 344);
            this.AddOrg.TabIndex = 0;
            this.AddOrg.Text = "Добавление ";
            this.AddOrg.Click += new System.EventHandler(this.AddOrg_Click);
            // 
            // rbtnCart
            // 
            this.rbtnCart.AutoSize = true;
            this.rbtnCart.Location = new System.Drawing.Point(290, 125);
            this.rbtnCart.Name = "rbtnCart";
            this.rbtnCart.Size = new System.Drawing.Size(103, 17);
            this.rbtnCart.TabIndex = 9;
            this.rbtnCart.Text = "Тип Картриджа";
            this.rbtnCart.UseVisualStyleBackColor = true;
            this.rbtnCart.CheckedChanged += new System.EventHandler(this.rbtnCart_CheckedChanged);
            // 
            // rbtnOrg
            // 
            this.rbtnOrg.AutoSize = true;
            this.rbtnOrg.Checked = true;
            this.rbtnOrg.Location = new System.Drawing.Point(192, 125);
            this.rbtnOrg.Name = "rbtnOrg";
            this.rbtnOrg.Size = new System.Drawing.Size(92, 17);
            this.rbtnOrg.TabIndex = 8;
            this.rbtnOrg.TabStop = true;
            this.rbtnOrg.Text = "Организация";
            this.rbtnOrg.UseVisualStyleBackColor = true;
            this.rbtnOrg.CheckedChanged += new System.EventHandler(this.rbtnOrg_CheckedChanged);
            // 
            // viewTable
            // 
            this.viewTable.AllowUserToAddRows = false;
            this.viewTable.AllowUserToDeleteRows = false;
            this.viewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewTable.Location = new System.Drawing.Point(8, 188);
            this.viewTable.Name = "viewTable";
            this.viewTable.ReadOnly = true;
            this.viewTable.RowHeadersWidth = 50;
            this.viewTable.Size = new System.Drawing.Size(640, 150);
            this.viewTable.TabIndex = 7;
            this.viewTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.viewTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewOrg_RowEnter);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.Location = new System.Drawing.Point(212, 148);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(228, 34);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddOrganization_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddress.Location = new System.Drawing.Point(175, 89);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 20);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Адрес:";
            // 
            // TextAddress
            // 
            this.TextAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextAddress.Location = new System.Drawing.Point(241, 89);
            this.TextAddress.Name = "TextAddress";
            this.TextAddress.Size = new System.Drawing.Size(184, 26);
            this.TextAddress.TabIndex = 4;
            // 
            // textUniquePr
            // 
            this.textUniquePr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textUniquePr.Location = new System.Drawing.Point(241, 57);
            this.textUniquePr.Name = "textUniquePr";
            this.textUniquePr.Size = new System.Drawing.Size(184, 26);
            this.textUniquePr.TabIndex = 2;
            // 
            // TextName
            // 
            this.TextName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextName.Location = new System.Drawing.Point(241, 25);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(184, 26);
            this.TextName.TabIndex = 0;
            // 
            // lblUpr
            // 
            this.lblUpr.AutoSize = true;
            this.lblUpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpr.Location = new System.Drawing.Point(58, 57);
            this.lblUpr.Name = "lblUpr";
            this.lblUpr.Size = new System.Drawing.Size(177, 20);
            this.lblUpr.TabIndex = 3;
            this.lblUpr.Text = "Уникальный префикс:";
            // 
            // lblNameOrg
            // 
            this.lblNameOrg.AutoSize = true;
            this.lblNameOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameOrg.Location = new System.Drawing.Point(8, 28);
            this.lblNameOrg.Name = "lblNameOrg";
            this.lblNameOrg.Size = new System.Drawing.Size(226, 20);
            this.lblNameOrg.TabIndex = 1;
            this.lblNameOrg.Text = "Наименование организации:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddOrg);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 370);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // rdbWorkT
            // 
            this.rdbWorkT.AutoSize = true;
            this.rdbWorkT.Location = new System.Drawing.Point(399, 125);
            this.rdbWorkT.Name = "rdbWorkT";
            this.rdbWorkT.Size = new System.Drawing.Size(76, 17);
            this.rdbWorkT.TabIndex = 10;
            this.rdbWorkT.Text = "Тип работ";
            this.rdbWorkT.UseVisualStyleBackColor = true;
            this.rdbWorkT.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.boxType);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.generateBtn);
            this.tabPage1.Controls.Add(this.boxOrg);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.BarcodePic);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(658, 344);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Объект";
            // 
            // BarcodePic
            // 
            this.BarcodePic.Image = ((System.Drawing.Image)(resources.GetObject("BarcodePic.Image")));
            this.BarcodePic.Location = new System.Drawing.Point(218, 166);
            this.BarcodePic.Name = "BarcodePic";
            this.BarcodePic.Size = new System.Drawing.Size(225, 100);
            this.BarcodePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BarcodePic.TabIndex = 0;
            this.BarcodePic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование организации:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // boxOrg
            // 
            this.boxOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxOrg.FormattingEnabled = true;
            this.boxOrg.Location = new System.Drawing.Point(232, 25);
            this.boxOrg.Name = "boxOrg";
            this.boxOrg.Size = new System.Drawing.Size(184, 28);
            this.boxOrg.TabIndex = 4;
            this.boxOrg.SelectedIndexChanged += new System.EventHandler(this.boxOrg_SelectedIndexChanged);
            // 
            // generateBtn
            // 
            this.generateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.generateBtn.Location = new System.Drawing.Point(226, 115);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(209, 41);
            this.generateBtn.TabIndex = 5;
            this.generateBtn.Text = "Генерация Штрих-кода";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxType
            // 
            this.boxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxType.FormattingEnabled = true;
            this.boxType.Location = new System.Drawing.Point(232, 59);
            this.boxType.Name = "boxType";
            this.boxType.Size = new System.Drawing.Size(184, 28);
            this.boxType.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(191, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Тип:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 370);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "ASOC";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.AddOrg.ResumeLayout(false);
            this.AddOrg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewTable)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage AddOrg;
        private System.Windows.Forms.RadioButton rbtnCart;
        private System.Windows.Forms.RadioButton rbtnOrg;
        private System.Windows.Forms.DataGridView viewTable;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox TextAddress;
        private System.Windows.Forms.TextBox textUniquePr;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label lblUpr;
        private System.Windows.Forms.Label lblNameOrg;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.RadioButton rdbWorkT;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox BarcodePic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxOrg;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.ComboBox boxType;
        private System.Windows.Forms.Label label2;
    }
}

