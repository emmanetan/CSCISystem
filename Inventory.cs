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
            Loadform(new Home());
        }
        private void Inventory_Load(object sender, EventArgs e)
        {
            loadingTimer.Start();
           
        }
        private void Loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            FadeInPanel(mainpanel);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();


        }

        bool reportExpand = false;
        private void dropDownTimer_Tick(object sender, EventArgs e)
        {
            if (reportExpand == false)
            {
                panelDropDown.Height +=10;
                if (panelDropDown.Height >= 183)
                {
                    dropDownTimer.Stop();
                    reportExpand = true;
                }
            }
            else
            {
                panelDropDown.Height -= 10;
                if (panelDropDown.Height <= 59)
                {
                    dropDownTimer.Stop();
                    reportExpand = false;
                }
            }
        }
        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            Opacity += .2;
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Loadform(new Home());
        }
        private void ProductBtn_Click(object sender, EventArgs e)
        {
            Loadform(new Product());
        }
        private void UserBtn_Click(object sender, EventArgs e)
        {
            Loadform(new User());
        }
        private void ReportBtn_Click(object sender, EventArgs e)
        {
            dropDownTimer.Start();
        }
        private void SalesRBtn_Click(object sender, EventArgs e)
        {
            Loadform(new SalesReport());
        }
        private void InventoryRBtn_Click(object sender, EventArgs e)
        {
            Loadform(new InventoryReport());
        }

        private void FadeInPanel(Panel panel)
        {           
            fadeTimer.Interval = 100; // Adjust the interval for smoother or faster fade
            panel.Visible = true;
            panel.BackColor = Color.FromArgb(0, panel.BackColor); // Start with transparent
            int opacity = 0;

            fadeTimer.Tick += (s, e) =>
            {
                opacity += 10; // Increase opacity incrementally
                if (opacity >= 255)
                {
                    opacity = 255;
                    fadeTimer.Stop();
                }
                panel.BackColor = Color.FromArgb(opacity, panel.BackColor.R, panel.BackColor.G, panel.BackColor.B);
            };

            fadeTimer.Start();
        }
    }
}
