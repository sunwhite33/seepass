using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

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
            fileDialog.Filter = "7zip|*.7z;|zip|*.bzip2;*.gzip;*.zip;";
            Thread t = new Thread((ThreadStart)(() =>
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string file = fileDialog.FileName;//返回文件的完整路径
                    //this.textBoxZipFilename.Text = file;
                }
            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridView curGrid = (DataGridView)sender;
            //MessageBox.Show("UserAddedRow");

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DataGridView curGrid = this.dataGridView1;
            DataTable dt = MainForm.GetDgvToTable(curGrid);
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
                Schema schema = new Schema();
                schema.zipFilename = textBoxZipFilename.Text;
                schema.passwordRules = passwordRules;
                string jsonData = JsonConvert.SerializeObject(schema);
                MessageBox.Show(jsonData);
                string path = "./schema/" + DateTime.Now.ToString("yyyyMMdd") + DateTime.Now.ToString("HHmmss") + ".json";
                Tools.WriteJsonFile(path, jsonData);
                MessageBox.Show("方案保存成功", "提示");

            }
        }

        /// <summary>
        /// 将dgv列表数据转换为datatable数据
        /// </summary>
        /// <param name="dgv">当前dgv列表对象</param>
        /// <returns>datatable对象</returns>
        private static DataTable GetDgvToTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            // 列强制转换
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                System.Data.DataColumn dc = new System.Data.DataColumn(dgv.Columns[count].Name.ToString());
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
            //string path = "./schema/" + DateTime.Now.ToString("yyyyMMdd") + DateTime.Now.ToString("HHmmss") + ".json";
            //Tools.WriteJsonFile(path, jsonData);
            //MessageBox.Show("方案保存成功", "提示");
        }
    }
}
