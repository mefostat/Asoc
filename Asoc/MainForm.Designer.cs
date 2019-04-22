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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AddOrg = new System.Windows.Forms.TabPage();
            this.TextName = new System.Windows.Forms.TextBox();
            this.lblNameOrg = new System.Windows.Forms.Label();
            this.textUniquePr = new System.Windows.Forms.TextBox();
            this.lblUpr = new System.Windows.Forms.Label();
            this.TextAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.viewTable = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.rbtnOrg = new System.Windows.Forms.RadioButton();
            this.rbtnCart = new System.Windows.Forms.RadioButton();
            this.AddOrg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewTable)).BeginInit();
            this.tabControl1.SuspendLayout();
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
            // TextName
            // 
            this.TextName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextName.Location = new System.Drawing.Point(241, 25);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(184, 26);
            this.TextName.TabIndex = 0;
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
            // textUniquePr
            // 
            this.textUniquePr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textUniquePr.Location = new System.Drawing.Point(241, 57);
            this.textUniquePr.Name = "textUniquePr";
            this.textUniquePr.Size = new System.Drawing.Size(184, 26);
            this.textUniquePr.TabIndex = 2;
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
            // TextAddress
            // 
            this.TextAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextAddress.Location = new System.Drawing.Point(241, 89);
            this.TextAddress.Name = "TextAddress";
            this.TextAddress.Size = new System.Drawing.Size(184, 26);
            this.TextAddress.TabIndex = 4;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddOrg);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 370);
            this.tabControl1.TabIndex = 0;
            // 
            // rbtnOrg
            // 
            this.rbtnOrg.AutoSize = true;
            this.rbtnOrg.Checked = true;
            this.rbtnOrg.Location = new System.Drawing.Point(212, 125);
            this.rbtnOrg.Name = "rbtnOrg";
            this.rbtnOrg.Size = new System.Drawing.Size(92, 17);
            this.rbtnOrg.TabIndex = 8;
            this.rbtnOrg.TabStop = true;
            this.rbtnOrg.Text = "Организация";
            this.rbtnOrg.UseVisualStyleBackColor = true;
            this.rbtnOrg.CheckedChanged += new System.EventHandler(this.rbtnOrg_CheckedChanged);
            // 
            // rbtnCart
            // 
            this.rbtnCart.AutoSize = true;
            this.rbtnCart.Location = new System.Drawing.Point(355, 125);
            this.rbtnCart.Name = "rbtnCart";
            this.rbtnCart.Size = new System.Drawing.Size(103, 17);
            this.rbtnCart.TabIndex = 9;
            this.rbtnCart.Text = "Тип Картриджа";
            this.rbtnCart.UseVisualStyleBackColor = true;
            this.rbtnCart.CheckedChanged += new System.EventHandler(this.rbtnCart_CheckedChanged);
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
    }
}

