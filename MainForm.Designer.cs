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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnPasswordSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPasswordCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPasswordPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIsCapitalized = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxSchema = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(50, 39);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "选择文件";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // textBoxZipFilename
            // 
            this.textBoxZipFilename.Location = new System.Drawing.Point(132, 40);
            this.textBoxZipFilename.Name = "textBoxZipFilename";
            this.textBoxZipFilename.ReadOnly = true;
            this.textBoxZipFilename.Size = new System.Drawing.Size(531, 21);
            this.textBoxZipFilename.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(50, 462);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(613, 23);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Value = 50;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPasswordSymbol,
            this.ColumnPasswordCount,
            this.ColumnPasswordPosition,
            this.ColumnIsCapitalized,
            this.Column5});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(50, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(613, 278);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            // 
            // ColumnPasswordSymbol
            // 
            this.ColumnPasswordSymbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPasswordSymbol.HeaderText = "密码字符";
            this.ColumnPasswordSymbol.Name = "ColumnPasswordSymbol";
            this.ColumnPasswordSymbol.ToolTipText = "可填入1至多个字符";
            // 
            // ColumnPasswordCount
            // 
            this.ColumnPasswordCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPasswordCount.HeaderText = "可能个数";
            this.ColumnPasswordCount.Name = "ColumnPasswordCount";
            this.ColumnPasswordCount.ToolTipText = "可填入1或大于1的数字";
            // 
            // ColumnPasswordPosition
            // 
            this.ColumnPasswordPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPasswordPosition.HeaderText = "可能位置";
            this.ColumnPasswordPosition.Name = "ColumnPasswordPosition";
            this.ColumnPasswordPosition.ToolTipText = "0-不确定，其他数字-所在位置";
            // 
            // ColumnIsCapitalized
            // 
            this.ColumnIsCapitalized.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnIsCapitalized.HeaderText = "有否对应大小写";
            this.ColumnIsCapitalized.Items.AddRange(new object[] {
            "no",
            "yes"});
            this.ColumnIsCapitalized.Name = "ColumnIsCapitalized";
            this.ColumnIsCapitalized.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnIsCapitalized.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnIsCapitalized.ToolTipText = "yes-有，no-没有";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "操作";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Text = "删除";
            this.Column5.ToolTipText = "点击删除按钮删除对应行";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "管理密码组合规则";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(588, 388);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "保存方案";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(50, 424);
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
            this.label2.Location = new System.Drawing.Point(680, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "方案列表";
            // 
            // listBoxSchema
            // 
            this.listBoxSchema.FormattingEnabled = true;
            this.listBoxSchema.ItemHeight = 12;
            this.listBoxSchema.Location = new System.Drawing.Point(682, 55);
            this.listBoxSchema.Name = "listBoxSchema";
            this.listBoxSchema.Size = new System.Drawing.Size(155, 352);
            this.listBoxSchema.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 591);
            this.Controls.Add(this.listBoxSchema);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBoxZipFilename);
            this.Controls.Add(this.buttonOpenFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "seepass - 密码破解";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox textBoxZipFilename;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPasswordSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPasswordCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPasswordPosition;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnIsCapitalized;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxSchema;
    }
}

