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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddOrg = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddOrganization = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblUpr = new System.Windows.Forms.Label();
            this.textUniquePr = new System.Windows.Forms.TextBox();
            this.lblNameOrg = new System.Windows.Forms.Label();
            this.TextNameOrg = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.AddOrg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddOrg);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 370);
            this.tabControl1.TabIndex = 0;
            // 
            // AddOrg
            // 
            this.AddOrg.BackColor = System.Drawing.Color.Gainsboro;
            this.AddOrg.Controls.Add(this.dataGridView1);
            this.AddOrg.Controls.Add(this.btnAddOrganization);
            this.AddOrg.Controls.Add(this.lblAddress);
            this.AddOrg.Controls.Add(this.textBox2);
            this.AddOrg.Controls.Add(this.lblUpr);
            this.AddOrg.Controls.Add(this.textUniquePr);
            this.AddOrg.Controls.Add(this.lblNameOrg);
            this.AddOrg.Controls.Add(this.TextNameOrg);
            this.AddOrg.Location = new System.Drawing.Point(4, 22);
            this.AddOrg.Name = "AddOrg";
            this.AddOrg.Padding = new System.Windows.Forms.Padding(3);
            this.AddOrg.Size = new System.Drawing.Size(658, 344);
            this.AddOrg.TabIndex = 0;
            this.AddOrg.Text = "Добавление организации";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnAddOrganization
            // 
            this.btnAddOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddOrganization.Location = new System.Drawing.Point(224, 138);
            this.btnAddOrganization.Name = "btnAddOrganization";
            this.btnAddOrganization.Size = new System.Drawing.Size(228, 34);
            this.btnAddOrganization.TabIndex = 6;
            this.btnAddOrganization.Text = "Добавить организацию";
            this.btnAddOrganization.UseVisualStyleBackColor = true;
            this.btnAddOrganization.Click += new System.EventHandler(this.btnAddOrganization_Click);
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
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(241, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 26);
            this.textBox2.TabIndex = 4;
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
            // textUniquePr
            // 
            this.textUniquePr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textUniquePr.Location = new System.Drawing.Point(241, 57);
            this.textUniquePr.Name = "textUniquePr";
            this.textUniquePr.Size = new System.Drawing.Size(184, 26);
            this.textUniquePr.TabIndex = 2;
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
            // TextNameOrg
            // 
            this.TextNameOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextNameOrg.Location = new System.Drawing.Point(241, 25);
            this.TextNameOrg.Name = "TextNameOrg";
            this.TextNameOrg.Size = new System.Drawing.Size(184, 26);
            this.TextNameOrg.TabIndex = 0;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 370);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "ASOC";
            this.tabControl1.ResumeLayout(false);
            this.AddOrg.ResumeLayout(false);
            this.AddOrg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddOrg;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblUpr;
        private System.Windows.Forms.TextBox textUniquePr;
        private System.Windows.Forms.Label lblNameOrg;
        private System.Windows.Forms.TextBox TextNameOrg;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddOrganization;
    }
}

