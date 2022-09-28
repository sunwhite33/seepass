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
    public partial class FormSponsor : Form
    {
        public FormSponsor()
        {
            InitializeComponent();
        }

        private void FormSponsor_Load(object sender, EventArgs e)
        {
        }

        private void linkLabelCopyEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetDataObject("skytalker@126.com");
        }
    }
}
