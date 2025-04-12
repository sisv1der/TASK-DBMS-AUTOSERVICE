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
            this.pFilterByGender = new System.Windows.Forms.Panel();
            this.cbxFilterByGender = new System.Windows.Forms.ComboBox();
            this.lblFilterByGender = new System.Windows.Forms.Label();
            this.pSortBy = new System.Windows.Forms.Panel();
            this.cbxSortBy = new System.Windows.Forms.ComboBox();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.pSearch = new System.Windows.Forms.Panel();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pSearchBy = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.pRows = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.pPages = new System.Windows.Forms.Panel();
            this.pDelete = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pEdit = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pAdd = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pVisitList = new System.Windows.Forms.Panel();
            this.btnVisitList = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pMainControls.SuspendLayout();
            this.pFilterByGender.SuspendLayout();
            this.pSortBy.SuspendLayout();
            this.pSearch.SuspendLayout();
            this.pSearchBy.SuspendLayout();
            this.pRows.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.pPages.SuspendLayout();
            this.pDelete.SuspendLayout();
            this.pEdit.SuspendLayout();
            this.pAdd.SuspendLayout();
            this.pVisitList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pLogo.Controls.Add(this.pbxLogo);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(1084, 100);
            this.pLogo.TabIndex = 0;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbxLogo.Image = global::СУБД_АВТОСЕРВИС.Properties.Resources.service_logo;
            this.pbxLogo.Location = new System.Drawing.Point(964, 0);
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
            this.pMainControls.Size = new System.Drawing.Size(1084, 100);
            this.pMainControls.TabIndex = 1;
            // 
            // pFilterByGender
            // 
            this.pFilterByGender.Controls.Add(this.cbxFilterByGender);
            this.pFilterByGender.Controls.Add(this.lblFilterByGender);
            this.pFilterByGender.Dock = System.Windows.Forms.DockStyle.Right;
            this.pFilterByGender.Location = new System.Drawing.Point(670, 0);
            this.pFilterByGender.Name = "pFilterByGender";
            this.pFilterByGender.Size = new System.Drawing.Size(205, 100);
            this.pFilterByGender.TabIndex = 3;
            // 
            // cbxFilterByGender
            // 
            this.cbxFilterByGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilterByGender.FormattingEnabled = true;
            this.cbxFilterByGender.Location = new System.Drawing.Point(16, 49);
            this.cbxFilterByGender.Name = "cbxFilterByGender";
            this.cbxFilterByGender.Size = new System.Drawing.Size(165, 21);
            this.cbxFilterByGender.TabIndex = 4;
            // 
            // lblFilterByGender
            // 
            this.lblFilterByGender.AutoSize = true;
            this.lblFilterByGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilterByGender.Location = new System.Drawing.Point(12, 16);
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
            this.pSortBy.Location = new System.Drawing.Point(875, 0);
            this.pSortBy.Name = "pSortBy";
            this.pSortBy.Size = new System.Drawing.Size(209, 100);
            this.pSortBy.TabIndex = 4;
            // 
            // cbxSortBy
            // 
            this.cbxSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSortBy.FormattingEnabled = true;
            this.cbxSortBy.Location = new System.Drawing.Point(16, 49);
            this.cbxSortBy.Name = "cbxSortBy";
            this.cbxSortBy.Size = new System.Drawing.Size(165, 21);
            this.cbxSortBy.TabIndex = 5;
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSortBy.Location = new System.Drawing.Point(12, 16);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(136, 20);
            this.lblSortBy.TabIndex = 4;
            this.lblSortBy.Text = "Сортировать по:";
            // 
            // pSearch
            // 
            this.pSearch.Controls.Add(this.tbxSearch);
            this.pSearch.Controls.Add(this.lblSearch);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSearch.Location = new System.Drawing.Point(423, 0);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(661, 100);
            this.pSearch.TabIndex = 2;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearch.Location = new System.Drawing.Point(16, 49);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(209, 20);
            this.tbxSearch.TabIndex = 3;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearch.Location = new System.Drawing.Point(12, 16);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(217, 20);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Введите текст для поиска:";
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
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(16, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(165, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchBy.Location = new System.Drawing.Point(12, 16);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(81, 20);
            this.lblSearchBy.TabIndex = 1;
            this.lblSearchBy.Text = "Поиск по:";
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 1;
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
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip.Location = new System.Drawing.Point(0, 689);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1084, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // pPages
            // 
            this.pPages.Controls.Add(this.pVisitList);
            this.pPages.Controls.Add(this.pDelete);
            this.pPages.Controls.Add(this.pEdit);
            this.pPages.Controls.Add(this.pAdd);
            this.pPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pPages.Location = new System.Drawing.Point(0, 589);
            this.pPages.Name = "pPages";
            this.pPages.Size = new System.Drawing.Size(1084, 100);
            this.pPages.TabIndex = 3;
            // 
            // pDelete
            // 
            this.pDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pDelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pDelete.Controls.Add(this.btnDelete);
            this.pDelete.Location = new System.Drawing.Point(423, 13);
            this.pDelete.Name = "pDelete";
            this.pDelete.Size = new System.Drawing.Size(179, 36);
            this.pDelete.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.BlueViolet;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(-1, -1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(179, 36);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // pEdit
            // 
            this.pEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pEdit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pEdit.Controls.Add(this.btnEdit);
            this.pEdit.Location = new System.Drawing.Point(223, 13);
            this.pEdit.Name = "pEdit";
            this.pEdit.Size = new System.Drawing.Size(179, 36);
            this.pEdit.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.BlueViolet;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Location = new System.Drawing.Point(-1, -1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(179, 36);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // pAdd
            // 
            this.pAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pAdd.Controls.Add(this.btnAdd);
            this.pAdd.Location = new System.Drawing.Point(23, 13);
            this.pAdd.Name = "pAdd";
            this.pAdd.Size = new System.Drawing.Size(179, 36);
            this.pAdd.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.BlueViolet;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(-1, -1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // pVisitList
            // 
            this.pVisitList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pVisitList.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pVisitList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pVisitList.Controls.Add(this.btnVisitList);
            this.pVisitList.Location = new System.Drawing.Point(875, 9);
            this.pVisitList.Name = "pVisitList";
            this.pVisitList.Size = new System.Drawing.Size(179, 36);
            this.pVisitList.TabIndex = 3;
            // 
            // btnVisitList
            // 
            this.btnVisitList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisitList.BackColor = System.Drawing.Color.BlueViolet;
            this.btnVisitList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVisitList.Location = new System.Drawing.Point(-1, -1);
            this.btnVisitList.Name = "btnVisitList";
            this.btnVisitList.Size = new System.Drawing.Size(179, 36);
            this.btnVisitList.TabIndex = 0;
            this.btnVisitList.Text = "Посещения";
            this.btnVisitList.UseVisualStyleBackColor = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(91, 17);
            this.toolStripStatusLabel1.Text = "Всего записей: ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel2.Text = "Отображается: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 711);
            this.Controls.Add(this.pPages);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pMainControls);
            this.Controls.Add(this.pLogo);
            this.MinimumSize = new System.Drawing.Size(1100, 750);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pMainControls.ResumeLayout(false);
            this.pFilterByGender.ResumeLayout(false);
            this.pFilterByGender.PerformLayout();
            this.pSortBy.ResumeLayout(false);
            this.pSortBy.PerformLayout();
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.pSearchBy.ResumeLayout(false);
            this.pSearchBy.PerformLayout();
            this.pRows.ResumeLayout(false);
            this.pRows.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pPages.ResumeLayout(false);
            this.pDelete.ResumeLayout(false);
            this.pEdit.ResumeLayout(false);
            this.pAdd.ResumeLayout(false);
            this.pVisitList.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel pAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pVisitList;
        private System.Windows.Forms.Button btnVisitList;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

