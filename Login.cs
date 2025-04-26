using AntdUI;
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
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
                       
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {   
            Login.ActiveForm.Hide(); 
            Inventory inventory = new Inventory();
            inventory.Show();
               
        }

        private void BtnPOS_Click(object sender, EventArgs e)
        {
            Login.ActiveForm.Hide();
            POS pos = new POS();
            pos.Show();
        }
    }
}
