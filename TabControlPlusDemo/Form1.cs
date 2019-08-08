using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControlPlusDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tabControlPlus1.Alignment = TabAlignment.Bottom;
            //tabControlPlus1.CloseButtonImage = Image.FromFile(@"d:\close_default.png");
            tabControlPlus1.CloseButtonImage = Properties.Resources.close_default;
            tabControlPlus1.closeButtonClicked += (i) =>
            {
                if (i == 0)
                {
                    return;
                }
                else
                {
                    tabControlPlus1.TabPages.RemoveAt(i);
                }
            };
        }
    }
}
