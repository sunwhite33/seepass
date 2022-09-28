using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace seepass
{
    public partial class FormManual : Form
    {
        public FormManual()
        {
            InitializeComponent();
        }

        private void FormManual_Load(object sender, EventArgs e)
        {
            this.richTextBoxManual.Text =
                "1、首先选择要破解的压缩包文件，目前支持7z、zip、bzip、gzip等文件类型；\r\n" +
                "\r\n" +
                "2、输入密码组合规则：\r\n" +
                "\r\n" +
                "（1）、密码字符，填入1个至多个字符，可以是单个字符，如a、b、x、y等，也可以是字符组合，如ab、cde、pqrst等；\r\n" +
                "\r\n" +
                "（2）、重复次数，填入0或大于0的数字，0表示没有重复，大于0表示重复个数，如1表示重复1次，2表示重复2两，依次类推；\r\n" +
                "\r\n" +
                "（3）、所在位置，填入0或大于0的数字，0表示不确定位置，大于0表示所在位置，如1表示第一位，2表示第二位，依次类推；\r\n" +
                "\r\n" +
                "（4）、存在大小写，选择否或者是，否表示不存在大小写，是表示存在大小写；\r\n" +
                "\r\n" +
                "3、点击保存方案按钮，可以将当前密码配置信息保存，以便于下次继续进行破解；\r\n" +
                "\r\n" +
                "4、点击开始破解，软件将根据设置的密码方案进行破解分析，请等待破解完成，破解完成后，将显示破解出来的密码；\r\n" +
                "\r\n" +
                "5、破解过程中可以点击暂停破解按钮，暂停之后再次点击开始破解将从暂停的位置开始继续破解；\r\n" +
                "\r\n" +
                "6、保存的方案显示在界面的右侧，可以点击方案名称，切换不同的破解方案；\r\n" +
                "\r\n" +
                "7、如果某个方案已不再需要，可以点击方案，再点击删除方案进行删除；\r\n" +
                "\r\n" +
                "8、点击使用说明，显示出本软件的功能说明和操作说明；\r\n" +
                "\r\n" +
                "9、点击复制邮箱，您可以把您想说的话发送给软件开发者；\r\n" +
                "\r\n" +
                "A、点击邀请赞助，您可以赞助软件开发者，以激励开发者继续开发新的功能，任何金额均可。\r\n" +
                "\r\n";
        }
    }
}
