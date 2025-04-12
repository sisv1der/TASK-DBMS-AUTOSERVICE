namespace СУБД_АВТОСЕРВИС
{
    partial class Form1
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
            this.pLogo = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pMainControls = new System.Windows.Forms.Panel();
            this.pRows = new System.Windows.Forms.Panel();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pSearchBy = new System.Windows.Forms.Panel();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.pFilterByGender = new System.Windows.Forms.Panel();
            this.lblFilterByGender = new System.Windows.Forms.Label();
            this.pSortBy = new System.Windows.Forms.Panel();
            this.cbxFilterByGender = new System.Windows.Forms.ComboBox();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.cbxSortBy = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.pPages = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pMainControls.SuspendLayout();
            this.pRows.SuspendLayout();
            this.pSearchBy.SuspendLayout();
            this.pSearch.SuspendLayout();
            this.pFilterByGender.SuspendLayout();
            this.pSortBy.SuspendLayout();
            this.pPages.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.Silver;
            this.pLogo.Controls.Add(this.pbxLogo);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(1153, 100);
            this.pLogo.TabIndex = 0;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbxLogo.Image = global::СУБД_АВТОСЕРВИС.Properties.Resources.service_logo;
            this.pbxLogo.Location = new System.Drawing.Point(1033, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(120, 100);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // pMainControls
            // 
            this.pMainControls.Controls.Add(this.pFilterByGender);
            this.pMainControls.Controls.Add(this.pSortBy);
            this.pMainControls.Controls.Add(this.pSearch);
            this.pMainControls.Controls.Add(this.pSearchBy);
            this.pMainControls.Controls.Add(this.pRows);
            this.pMainControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMainControls.Location = new System.Drawing.Point(0, 100);
            this.pMainControls.Name = "pMainControls";
            this.pMainControls.Size = new System.Drawing.Size(1153, 100);
            this.pMainControls.TabIndex = 1;
            // 
            // pRows
            // 
            this.pRows.Controls.Add(this.comboBox1);
            this.pRows.Controls.Add(this.lblRowCount);
            this.pRows.Dock = System.Windows.Forms.DockStyle.Left;
            this.pRows.Location = new System.Drawing.Point(0, 0);
            this.pRows.Name = "pRows";
            this.pRows.Size = new System.Drawing.Size(223, 100);
            this.pRows.TabIndex = 0;
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRowCount.Location = new System.Drawing.Point(12, 16);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(169, 20);
            this.lblRowCount.TabIndex = 0;
            this.lblRowCount.Text = "Количество записей:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // pSearchBy
            // 
            this.pSearchBy.Controls.Add(this.comboBox2);
            this.pSearchBy.Controls.Add(this.lblSearchBy);
            this.pSearchBy.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSearchBy.Location = new System.Drawing.Point(223, 0);
            this.pSearchBy.Name = "pSearchBy";
            this.pSearchBy.Size = new System.Drawing.Size(200, 100);
            this.pSearchBy.TabIndex = 1;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchBy.Location = new System.Drawing.Point(6, 16);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(81, 20);
            this.lblSearchBy.TabIndex = 1;
            this.lblSearchBy.Text = "Поиск по:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(10, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(165, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // pSearch
            // 
            this.pSearch.Controls.Add(this.tbxSearch);
            this.pSearch.Controls.Add(this.lblSearch);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSearch.Location = new System.Drawing.Point(423, 0);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(730, 100);
            this.pSearch.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearch.Location = new System.Drawing.Point(20, 16);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(217, 20);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Введите текст для поиска:";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearch.Location = new System.Drawing.Point(24, 50);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(278, 20);
            this.tbxSearch.TabIndex = 3;
            // 
            // pFilterByGender
            // 
            this.pFilterByGender.Controls.Add(this.cbxFilterByGender);
            this.pFilterByGender.Controls.Add(this.lblFilterByGender);
            this.pFilterByGender.Dock = System.Windows.Forms.DockStyle.Right;
            this.pFilterByGender.Location = new System.Drawing.Point(745, 0);
            this.pFilterByGender.Name = "pFilterByGender";
            this.pFilterByGender.Size = new System.Drawing.Size(187, 100);
            this.pFilterByGender.TabIndex = 3;
            // 
            // lblFilterByGender
            // 
            this.lblFilterByGender.AutoSize = true;
            this.lblFilterByGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilterByGender.Location = new System.Drawing.Point(3, 16);
            this.lblFilterByGender.Name = "lblFilterByGender";
            this.lblFilterByGender.Size = new System.Drawing.Size(171, 20);
            this.lblFilterByGender.TabIndex = 3;
            this.lblFilterByGender.Text = "Фильтрация по полу:";
            // 
            // pSortBy
            // 
            this.pSortBy.Controls.Add(this.cbxSortBy);
            this.pSortBy.Controls.Add(this.lblSortBy);
            this.pSortBy.Dock = System.Windows.Forms.DockStyle.Right;
            this.pSortBy.Location = new System.Drawing.Point(932, 0);
            this.pSortBy.Name = "pSortBy";
            this.pSortBy.Size = new System.Drawing.Size(221, 100);
            this.pSortBy.TabIndex = 4;
            // 
            // cbxFilterByGender
            // 
            this.cbxFilterByGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilterByGender.FormattingEnabled = true;
            this.cbxFilterByGender.Location = new System.Drawing.Point(9, 49);
            this.cbxFilterByGender.Name = "cbxFilterByGender";
            this.cbxFilterByGender.Size = new System.Drawing.Size(165, 21);
            this.cbxFilterByGender.TabIndex = 4;
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSortBy.Location = new System.Drawing.Point(21, 16);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(136, 20);
            this.lblSortBy.TabIndex = 4;
            this.lblSortBy.Text = "Сортировать по:";
            // 
            // cbxSortBy
            // 
            this.cbxSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSortBy.FormattingEnabled = true;
            this.cbxSortBy.Location = new System.Drawing.Point(25, 49);
            this.cbxSortBy.Name = "cbxSortBy";
            this.cbxSortBy.Size = new System.Drawing.Size(165, 21);
            this.cbxSortBy.TabIndex = 5;
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 533);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1153, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // pPages
            // 
            this.pPages.Controls.Add(this.panel3);
            this.pPages.Controls.Add(this.panel2);
            this.pPages.Controls.Add(this.panel1);
            this.pPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pPages.Location = new System.Drawing.Point(0, 433);
            this.pPages.Name = "pPages";
            this.pPages.Size = new System.Drawing.Size(1153, 100);
            this.pPages.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(23, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 36);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(471, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 36);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 28);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(919, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 36);
            this.panel3.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 28);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 555);
            this.Controls.Add(this.pPages);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pMainControls);
            this.Controls.Add(this.pLogo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pMainControls.ResumeLayout(false);
            this.pRows.ResumeLayout(false);
            this.pRows.PerformLayout();
            this.pSearchBy.ResumeLayout(false);
            this.pSearchBy.PerformLayout();
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.pFilterByGender.ResumeLayout(false);
            this.pFilterByGender.PerformLayout();
            this.pSortBy.ResumeLayout(false);
            this.pSortBy.PerformLayout();
            this.pPages.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel pMainControls;
        private System.Windows.Forms.Panel pRows;
        private System.Windows.Forms.Panel pSearch;
        private System.Windows.Forms.Panel pSearchBy;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pFilterByGender;
        private System.Windows.Forms.ComboBox cbxFilterByGender;
        private System.Windows.Forms.Label lblFilterByGender;
        private System.Windows.Forms.Panel pSortBy;
        private System.Windows.Forms.ComboBox cbxSortBy;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel pPages;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

