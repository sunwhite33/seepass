using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.ActivationContext;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace seepass
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            //fileDialog.Filter = "7zip|*.7z;|zip|*.bzip2;*.gzip;*.zip;";
            fileDialog.Filter = "7z,zip,bz,gz|*.7z;*.bzip2;*.gzip;*.zip;";
            Thread t = new Thread((ThreadStart)(() =>
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.textBoxZipFilename.BeginInvoke((MethodInvoker)delegate ()
                    {
                        string file = fileDialog.FileName;
                        this.textBoxZipFilename.Text = file;
                    });
                }
            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }

        private void dataGridViewSchema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView curGrid = (DataGridView)sender;
            //MessageBox.Show("CellContentClick");
            //MessageBox.Show(this.dataGridView1.CurrentCell.Value.ToString());
            //MessageBox.Show(curGrid.CurrentCell.Value.ToString());
            //MessageBox.Show(sender.GetType().ToString());
            //MessageBox.Show(curGrid.GetType().ToString());
            //MessageBox.Show(curGrid.CurrentRow.IsNewRow.ToString());
            if (curGrid.CurrentRow.IsNewRow == false)
            {
                curGrid.Rows.Remove(curGrid.CurrentRow);
                curGrid.Refresh();
            }

        }

        private void dataGridViewSchema_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridView curGrid = (DataGridView)sender;
            //MessageBox.Show("UserAddedRow");

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string zipFilename = textBoxZipFilename.Text;
            if (zipFilename == "" || zipFilename == null)
            {
                MessageBox.Show("请先选择压缩包文件");
                return;
            }
            DataGridView curGrid = this.dataGridViewSchema;
            DataTable dt = MainForm.GetDatagridViewToTable(curGrid);
            List<PasswordRule> passwordRules = new List<PasswordRule>();
            bool isDataMissing = false;
            for (int i = 0; i<dt.Rows.Count-1; i++)
            {
                PasswordRule passwordRule = new PasswordRule();
                if (string.IsNullOrEmpty(dt.Rows[i]["ColumnPasswordSymbol"].ToString()))
                {
                    MessageBox.Show("密码字符不能为空");
                    isDataMissing = true;
                    break;
                }
                if (string.IsNullOrEmpty(dt.Rows[i]["ColumnPasswordCount"].ToString()))
                {
                    MessageBox.Show("可能个数不能为空");
                    isDataMissing = true;
                    break;
                }
                if (string.IsNullOrEmpty(dt.Rows[i]["ColumnPasswordPosition"].ToString()))
                {
                    MessageBox.Show("可能位置不能为空");
                    isDataMissing = true;
                    break;
                }
                if (string.IsNullOrEmpty(dt.Rows[i]["ColumnIsCapitalized"].ToString()))
                {
                    MessageBox.Show("是否对应大小写不能为空");
                    isDataMissing = true;
                    break;
                }
                passwordRule.passwordSymbol = dt.Rows[i]["ColumnPasswordSymbol"].ToString();
                passwordRule.passwordCount = Convert.ToInt32(dt.Rows[i]["ColumnPasswordCount"]);
                passwordRule.passwordPosition = Convert.ToInt32(dt.Rows[i]["ColumnPasswordPosition"]);
                passwordRule.isCapitalized = dt.Rows[i]["ColumnIsCapitalized"].ToString();
                passwordRules.Add(passwordRule);
            }
            // 判断数据是否完整，如没有遗漏数据，则保存到json文件中
            if (isDataMissing == false)
            {
                string filenameWithoutExtension = Path.GetFileNameWithoutExtension(zipFilename);// 没有扩展名的文件名
                string schemaName = filenameWithoutExtension;
                Console.WriteLine(schemaName);
                Schema schema = new Schema();
                schema.name = schemaName;
                schema.zipFilename = zipFilename;
                schema.passwordRules = passwordRules;
                string jsonStr = JsonConvert.SerializeObject(schema);
                //MessageBox.Show(jsonStr);
                //string path = "./schema/" + DateTime.Now.ToString("yyyyMMdd") + DateTime.Now.ToString("HHmmss") + ".json";
                string path = "./schema/" + schemaName + ".json";
                Tools.WriteJsonFile(path, jsonStr);
                if (this.listBoxSchema.Items.Contains(schemaName) == false)
                {
                    this.listBoxSchema.Items.Add(schemaName);
                }
                MessageBox.Show("方案保存成功", "提示");
            }
        }

        /// <summary>
        /// 将datagridview列表数据转换为datatable数据
        /// </summary>
        /// <param name="dgv">当前dgv列表对象</param>
        /// <returns>datatable对象</returns>
        private static DataTable GetDatagridViewToTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            // 列强制转换
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                dt.Columns.Add(dc);
            }

            // 循环行
            for (int count = 0; count < dgv.Rows.Count; count++)
            {
                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
                {
                    dr[countsub] = Convert.ToString(dgv.Rows[count].Cells[countsub].Value);
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        /// <summary>
        /// 转换DataRow到实体对象
        /// </summary>
        /// <param name="objType"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        public static object ConvertRowToObject(Type objType, DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            DataTable table = row.Table;
            object target = Activator.CreateInstance(objType);
            foreach (DataColumn column in table.Columns)
            {
                PropertyInfo property = objType.GetProperty(column.ColumnName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (property == null)
                {
                    return null;
                    //throw new PropertyNotFoundException(column.ColumnName);
                }
                Type propertyType = property.PropertyType;
                object obj3 = null;
                bool flag = true;
                try
                {
                    obj3 = TypeHelper.ChangeType(propertyType, row[column.ColumnName]);
                }
                catch
                {
                    flag = false;
                }
                if (flag)
                {
                    object[] args = new object[] { obj3 };
                    objType.InvokeMember(column.ColumnName, BindingFlags.SetProperty | BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase, null, target, args);
                }
            }
            return target;
        }

        private void buttonCrack_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string path = "./schema/";
            string[] filenames = Tools.EnumerateFiles(path);
            if (filenames != null)
            {
                //listBoxSchema.Items.AddRange(filenames);
                foreach (var filename in filenames)
                {
                    string filenameWithoutExtension = Path.GetFileNameWithoutExtension(filename);// 没有扩展名的文件名
                    listBoxSchema.Items.Add(filenameWithoutExtension);
                }
            }
        }

        private void listBoxSchema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSchema.SelectedItem != null)
            {
                // 清除datagridview
                this.dataGridViewSchema.Rows.Clear();
                // 新加数据
                string schemaName = listBoxSchema.SelectedItem.ToString();
                string path = "./schema/" + schemaName + ".json";
                string jsonStr = Tools.ReadJsonFile(path);
                //MessageBox.Show(jsonStr);
                Schema schema = JsonConvert.DeserializeObject<Schema>(jsonStr);
                Console.WriteLine(schema);
                Console.WriteLine(schema.GetType());
                string zipFilename = schema.zipFilename;
                this.textBoxZipFilename.Text = zipFilename;
                List<PasswordRule> passwordRules = schema.passwordRules;
                foreach (PasswordRule passwordRule in passwordRules)
                {
                    this.dataGridViewSchema.Rows.Add(passwordRule.passwordSymbol, passwordRule.passwordCount,
                        passwordRule.passwordPosition, passwordRule.isCapitalized);
                }
                this.buttonDelete.Enabled = true;
            }
            else
            {
                this.buttonDelete.Enabled = false;
            }
        }

        private void textBoxZipFilename_TextChanged(object sender, EventArgs e)
        {
            string zipFilename = ((System.Windows.Forms.TextBox)sender).Text.ToString();
            if (zipFilename == "" || zipFilename == null)
            {
                this.buttonSave.Enabled = false;
            }
            else
            {
                this.buttonSave.Enabled = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // 删除配置文件
            string schemaName = listBoxSchema.SelectedItem.ToString();
            string path = "./schema/" + schemaName + ".json";
            Tools.DeleteFile(path);
            this.listBoxSchema.Items.Remove(this.listBoxSchema.SelectedItem);
            this.textBoxZipFilename.Clear();
            this.dataGridViewSchema.Rows.Clear();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelCopyEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetDataObject("skytalker@126.com");
        }

        private void linkLabelManual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormManual form = new FormManual();
            this.Invoke(new Action(() =>
            {
                form.ShowDialog(this);
            }));
        }

        private void linkLabelSponsor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSponsor form = new FormSponsor();
            this.Invoke(new Action(() =>
            {
                form.ShowDialog(this);
            }));
        }
    }
}
