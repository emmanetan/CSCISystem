using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCISystem
{
    public partial class Inventory: Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        bool reportExpand = false;
        private void dropDownTimer_Tick(object sender, EventArgs e)
        {
            if (reportExpand == false)
            {
                panelDropDown.Height +=10;
                if (panelDropDown.Height >= 202)
                {
                    dropDownTimer.Stop();
                    reportExpand = true;
                }
            }
            else
            {
                panelDropDown.Height -= 10;
                if (panelDropDown.Height <= 67)
                {
                    dropDownTimer.Stop();
                    reportExpand = false;
                }
            }
        }
        private void ReportBtn_Click(object sender, EventArgs e)
        {
            dropDownTimer.Start();
        }
    }
}
