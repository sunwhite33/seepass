namespace seepass
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.textBoxZipFilename = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dataGridViewSchema = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxSchema = new System.Windows.Forms.ListBox();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabelManual = new System.Windows.Forms.LinkLabel();
            this.linkLabelSponsor = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ColumnPasswordSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPasswordCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPasswordPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIsCapitalized = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnOperation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.linkLabelCopyEmail = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchema)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(27, 23);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "选择文件";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // textBoxZipFilename
            // 
            this.textBoxZipFilename.Location = new System.Drawing.Point(109, 24);
            this.textBoxZipFilename.Name = "textBoxZipFilename";
            this.textBoxZipFilename.ReadOnly = true;
            this.textBoxZipFilename.Size = new System.Drawing.Size(729, 21);
            this.textBoxZipFilename.TabIndex = 1;
            this.textBoxZipFilename.TextChanged += new System.EventHandler(this.textBoxZipFilename_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 478);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(613, 23);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Value = 50;
            // 
            // dataGridViewSchema
            // 
            this.dataGridViewSchema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPasswordSymbol,
            this.ColumnPasswordCount,
            this.ColumnPasswordPosition,
            this.ColumnIsCapitalized,
            this.ColumnOperation});
            this.dataGridViewSchema.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewSchema.Location = new System.Drawing.Point(27, 88);
            this.dataGridViewSchema.Name = "dataGridViewSchema";
            this.dataGridViewSchema.RowTemplate.Height = 23;
            this.dataGridViewSchema.Size = new System.Drawing.Size(613, 304);
            this.dataGridViewSchema.TabIndex = 4;
            this.dataGridViewSchema.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSchema_CellContentClick);
            this.dataGridViewSchema.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewSchema_UserAddedRow);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "管理密码组合规则";
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(565, 402);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "保存方案";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "开始破解";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonCrack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "方案列表";
            // 
            // listBoxSchema
            // 
            this.listBoxSchema.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxSchema.ForeColor = System.Drawing.Color.Black;
            this.listBoxSchema.FormattingEnabled = true;
            this.listBoxSchema.ItemHeight = 16;
            this.listBoxSchema.Location = new System.Drawing.Point(659, 87);
            this.listBoxSchema.Name = "listBoxSchema";
            this.listBoxSchema.Size = new System.Drawing.Size(179, 276);
            this.listBoxSchema.TabIndex = 7;
            this.listBoxSchema.SelectedIndexChanged += new System.EventHandler(this.listBoxSchema_SelectedIndexChanged);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(118, 440);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPause.TabIndex = 8;
            this.buttonPause.Text = "暂停破解";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(763, 369);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "删除方案";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "seepass - 密码破解（2022版）";
            // 
            // linkLabelManual
            // 
            this.linkLabelManual.AutoSize = true;
            this.linkLabelManual.Location = new System.Drawing.Point(3, 86);
            this.linkLabelManual.Name = "linkLabelManual";
            this.linkLabelManual.Size = new System.Drawing.Size(53, 12);
            this.linkLabelManual.TabIndex = 10;
            this.linkLabelManual.TabStop = true;
            this.linkLabelManual.Text = "使用说明";
            this.linkLabelManual.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelManual_LinkClicked);
            // 
            // linkLabelSponsor
            // 
            this.linkLabelSponsor.AutoSize = true;
            this.linkLabelSponsor.Location = new System.Drawing.Point(121, 86);
            this.linkLabelSponsor.Name = "linkLabelSponsor";
            this.linkLabelSponsor.Size = new System.Drawing.Size(53, 12);
            this.linkLabelSponsor.TabIndex = 10;
            this.linkLabelSponsor.TabStop = true;
            this.linkLabelSponsor.Text = "邀请赞助";
            this.linkLabelSponsor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSponsor_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "发布时间：2022-09-30";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkLabelCopyEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.linkLabelSponsor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.linkLabelManual);
            this.panel1.Location = new System.Drawing.Point(659, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 110);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "邮箱地址：skytalker@126.com";
            // 
            // ColumnPasswordSymbol
            // 
            this.ColumnPasswordSymbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPasswordSymbol.HeaderText = "密码字符";
            this.ColumnPasswordSymbol.Name = "ColumnPasswordSymbol";
            this.ColumnPasswordSymbol.ToolTipText = "填入1个至多个字符";
            // 
            // ColumnPasswordCount
            // 
            this.ColumnPasswordCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPasswordCount.HeaderText = "重复次数";
            this.ColumnPasswordCount.Name = "ColumnPasswordCount";
            this.ColumnPasswordCount.ToolTipText = "填入0或大于0的数字，0表示没有重复，大于0表示重复个数，如1表示重复1次，2表示重复2两，依次类推";
            // 
            // ColumnPasswordPosition
            // 
            this.ColumnPasswordPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPasswordPosition.HeaderText = "所在位置";
            this.ColumnPasswordPosition.Name = "ColumnPasswordPosition";
            this.ColumnPasswordPosition.ToolTipText = "填入0或大于0的数字，0表示不确定位置，大于0表示所在位置，如1表示第一位，2表示第二位，依次类推";
            // 
            // ColumnIsCapitalized
            // 
            this.ColumnIsCapitalized.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnIsCapitalized.HeaderText = "存在大小写";
            this.ColumnIsCapitalized.Items.AddRange(new object[] {
            "否",
            "是"});
            this.ColumnIsCapitalized.Name = "ColumnIsCapitalized";
            this.ColumnIsCapitalized.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnIsCapitalized.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnIsCapitalized.ToolTipText = "选择否或者是，否表示不存在大小写，是表示存在大小写";
            // 
            // ColumnOperation
            // 
            this.ColumnOperation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOperation.HeaderText = "操作";
            this.ColumnOperation.Name = "ColumnOperation";
            this.ColumnOperation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnOperation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnOperation.Text = "删除";
            this.ColumnOperation.ToolTipText = "点击删除按钮删除对应行";
            this.ColumnOperation.UseColumnTextForButtonValue = true;
            // 
            // linkLabelCopyEmail
            // 
            this.linkLabelCopyEmail.AutoSize = true;
            this.linkLabelCopyEmail.Location = new System.Drawing.Point(62, 86);
            this.linkLabelCopyEmail.Name = "linkLabelCopyEmail";
            this.linkLabelCopyEmail.Size = new System.Drawing.Size(53, 12);
            this.linkLabelCopyEmail.TabIndex = 11;
            this.linkLabelCopyEmail.TabStop = true;
            this.linkLabelCopyEmail.Text = "复制邮箱";
            this.linkLabelCopyEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCopyEmail_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.listBoxSchema);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSchema);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBoxZipFilename);
            this.Controls.Add(this.buttonOpenFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "seepass - 密码破解（2022版）";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchema)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox textBoxZipFilename;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dataGridViewSchema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxSchema;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabelManual;
        private System.Windows.Forms.LinkLabel linkLabelSponsor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPasswordSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPasswordCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPasswordPosition;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnIsCapitalized;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnOperation;
        private System.Windows.Forms.LinkLabel linkLabelCopyEmail;
    }
}

