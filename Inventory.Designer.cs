namespace CSCISystem
{
    partial class Inventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneRoundedButton7 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneShadowPanel2 = new Siticone.UI.WinForms.SiticoneShadowPanel();
            this.panelDropDown = new AntdUI.In.FlowLayoutPanel();
            this.ReportBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.SalesRBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.InventoryRBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.HomeBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.ProductBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.UserBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.mainpanel = new Siticone.UI.WinForms.SiticoneShadowPanel();
            this.dropDownTimer = new System.Windows.Forms.Timer(this.components);
            this.loadingTimer = new System.Windows.Forms.Timer(this.components);
            this.fadeTimer = new System.Windows.Forms.Timer(this.components);
            this.siticoneShadowPanel1 = new Siticone.UI.WinForms.SiticoneShadowPanel();
            this.siticoneShadowPanel2.SuspendLayout();
            this.panelDropDown.SuspendLayout();
            this.siticoneShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.Color.Black;
            this.siticoneLabel1.Location = new System.Drawing.Point(85, 28);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(179, 28);
            this.siticoneLabel1.TabIndex = 7;
            this.siticoneLabel1.Text = "INVENTORY SYSTEM";
            // 
            // siticoneRoundedButton7
            // 
            this.siticoneRoundedButton7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.siticoneRoundedButton7.CheckedState.Parent = this.siticoneRoundedButton7;
            this.siticoneRoundedButton7.CustomImages.Parent = this.siticoneRoundedButton7;
            this.siticoneRoundedButton7.FillColor = System.Drawing.Color.White;
            this.siticoneRoundedButton7.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton7.ForeColor = System.Drawing.Color.Black;
            this.siticoneRoundedButton7.HoveredState.Parent = this.siticoneRoundedButton7;
            this.siticoneRoundedButton7.Image = ((System.Drawing.Image)(resources.GetObject("siticoneRoundedButton7.Image")));
            this.siticoneRoundedButton7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneRoundedButton7.ImageSize = new System.Drawing.Size(27, 27);
            this.siticoneRoundedButton7.Location = new System.Drawing.Point(1051, 20);
            this.siticoneRoundedButton7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.siticoneRoundedButton7.Name = "siticoneRoundedButton7";
            this.siticoneRoundedButton7.ShadowDecoration.Parent = this.siticoneRoundedButton7;
            this.siticoneRoundedButton7.Size = new System.Drawing.Size(111, 44);
            this.siticoneRoundedButton7.TabIndex = 6;
            this.siticoneRoundedButton7.Text = "LOG OUT";
            this.siticoneRoundedButton7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // siticoneShadowPanel2
            // 
            this.siticoneShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShadowPanel2.Controls.Add(this.HomeBtn);
            this.siticoneShadowPanel2.Controls.Add(this.UserBtn);
            this.siticoneShadowPanel2.Controls.Add(this.panelDropDown);
            this.siticoneShadowPanel2.Controls.Add(this.ProductBtn);
            this.siticoneShadowPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticoneShadowPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.siticoneShadowPanel2.Location = new System.Drawing.Point(8, 91);
            this.siticoneShadowPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.siticoneShadowPanel2.Name = "siticoneShadowPanel2";
            this.siticoneShadowPanel2.Radius = 10;
            this.siticoneShadowPanel2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneShadowPanel2.ShadowDepth = 50;
            this.siticoneShadowPanel2.Size = new System.Drawing.Size(322, 622);
            this.siticoneShadowPanel2.TabIndex = 1;
            // 
            // panelDropDown
            // 
            this.panelDropDown.Controls.Add(this.ReportBtn);
            this.panelDropDown.Controls.Add(this.SalesRBtn);
            this.panelDropDown.Controls.Add(this.InventoryRBtn);
            this.panelDropDown.Location = new System.Drawing.Point(25, 197);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelDropDown.Size = new System.Drawing.Size(268, 55);
            this.panelDropDown.TabIndex = 2;
            // 
            // ReportBtn
            // 
            this.ReportBtn.CheckedState.Parent = this.ReportBtn;
            this.ReportBtn.CustomImages.Parent = this.ReportBtn;
            this.ReportBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ReportBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportBtn.ForeColor = System.Drawing.Color.Black;
            this.ReportBtn.HoveredState.Parent = this.ReportBtn;
            this.ReportBtn.Image = ((System.Drawing.Image)(resources.GetObject("ReportBtn.Image")));
            this.ReportBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ReportBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.ReportBtn.Location = new System.Drawing.Point(0, 5);
            this.ReportBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.ShadowDecoration.Parent = this.ReportBtn;
            this.ReportBtn.Size = new System.Drawing.Size(264, 44);
            this.ReportBtn.TabIndex = 3;
            this.ReportBtn.Text = "Report";
            this.ReportBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // SalesRBtn
            // 
            this.SalesRBtn.CheckedState.Parent = this.SalesRBtn;
            this.SalesRBtn.CustomImages.Parent = this.SalesRBtn;
            this.SalesRBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.SalesRBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesRBtn.ForeColor = System.Drawing.Color.Black;
            this.SalesRBtn.HoveredState.Parent = this.SalesRBtn;
            this.SalesRBtn.Image = ((System.Drawing.Image)(resources.GetObject("SalesRBtn.Image")));
            this.SalesRBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SalesRBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.SalesRBtn.Location = new System.Drawing.Point(44, 59);
            this.SalesRBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalesRBtn.Name = "SalesRBtn";
            this.SalesRBtn.ShadowDecoration.Parent = this.SalesRBtn;
            this.SalesRBtn.Size = new System.Drawing.Size(220, 44);
            this.SalesRBtn.TabIndex = 4;
            this.SalesRBtn.Text = " Sales Report";
            this.SalesRBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SalesRBtn.Click += new System.EventHandler(this.SalesRBtn_Click);
            // 
            // InventoryRBtn
            // 
            this.InventoryRBtn.CheckedState.Parent = this.InventoryRBtn;
            this.InventoryRBtn.CustomImages.Parent = this.InventoryRBtn;
            this.InventoryRBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.InventoryRBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryRBtn.ForeColor = System.Drawing.Color.Black;
            this.InventoryRBtn.HoveredState.Parent = this.InventoryRBtn;
            this.InventoryRBtn.Image = ((System.Drawing.Image)(resources.GetObject("InventoryRBtn.Image")));
            this.InventoryRBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InventoryRBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.InventoryRBtn.Location = new System.Drawing.Point(44, 113);
            this.InventoryRBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InventoryRBtn.Name = "InventoryRBtn";
            this.InventoryRBtn.ShadowDecoration.Parent = this.InventoryRBtn;
            this.InventoryRBtn.Size = new System.Drawing.Size(220, 44);
            this.InventoryRBtn.TabIndex = 5;
            this.InventoryRBtn.Text = " Inventory Report";
            this.InventoryRBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InventoryRBtn.Click += new System.EventHandler(this.InventoryRBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.CheckedState.Parent = this.HomeBtn;
            this.HomeBtn.CustomImages.Parent = this.HomeBtn;
            this.HomeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.HomeBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.Black;
            this.HomeBtn.HoveredState.Parent = this.HomeBtn;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomeBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.HomeBtn.Location = new System.Drawing.Point(25, 32);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.ShadowDecoration.Parent = this.HomeBtn;
            this.HomeBtn.Size = new System.Drawing.Size(268, 44);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // ProductBtn
            // 
            this.ProductBtn.CheckedState.Parent = this.ProductBtn;
            this.ProductBtn.CustomImages.Parent = this.ProductBtn;
            this.ProductBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ProductBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductBtn.ForeColor = System.Drawing.Color.Black;
            this.ProductBtn.HoveredState.Parent = this.ProductBtn;
            this.ProductBtn.Image = ((System.Drawing.Image)(resources.GetObject("ProductBtn.Image")));
            this.ProductBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProductBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.ProductBtn.Location = new System.Drawing.Point(25, 86);
            this.ProductBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductBtn.Name = "ProductBtn";
            this.ProductBtn.ShadowDecoration.Parent = this.ProductBtn;
            this.ProductBtn.Size = new System.Drawing.Size(268, 44);
            this.ProductBtn.TabIndex = 2;
            this.ProductBtn.Text = "Product";
            this.ProductBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProductBtn.Click += new System.EventHandler(this.ProductBtn_Click);
            // 
            // UserBtn
            // 
            this.UserBtn.CheckedState.Parent = this.UserBtn;
            this.UserBtn.CustomImages.Parent = this.UserBtn;
            this.UserBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.UserBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBtn.ForeColor = System.Drawing.Color.Black;
            this.UserBtn.HoveredState.Parent = this.UserBtn;
            this.UserBtn.Image = ((System.Drawing.Image)(resources.GetObject("UserBtn.Image")));
            this.UserBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.UserBtn.Location = new System.Drawing.Point(25, 145);
            this.UserBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.ShadowDecoration.Parent = this.UserBtn;
            this.UserBtn.Size = new System.Drawing.Size(268, 44);
            this.UserBtn.TabIndex = 1;
            this.UserBtn.Text = "User";
            this.UserBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserBtn.Click += new System.EventHandler(this.UserBtn_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.Transparent;
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.mainpanel.Location = new System.Drawing.Point(330, 91);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Radius = 10;
            this.mainpanel.ShadowColor = System.Drawing.Color.Black;
            this.mainpanel.ShadowDepth = 50;
            this.mainpanel.Size = new System.Drawing.Size(855, 622);
            this.mainpanel.TabIndex = 2;
            // 
            // dropDownTimer
            // 
            this.dropDownTimer.Interval = 1;
            this.dropDownTimer.Tick += new System.EventHandler(this.dropDownTimer_Tick);
            // 
            // loadingTimer
            // 
            this.loadingTimer.Interval = 1000;
            this.loadingTimer.Tick += new System.EventHandler(this.loadingTimer_Tick);
            // 
            // siticoneShadowPanel1
            // 
            this.siticoneShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShadowPanel1.Controls.Add(this.siticoneLabel1);
            this.siticoneShadowPanel1.Controls.Add(this.siticoneRoundedButton7);
            this.siticoneShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.siticoneShadowPanel1.Location = new System.Drawing.Point(8, 8);
            this.siticoneShadowPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.siticoneShadowPanel1.Name = "siticoneShadowPanel1";
            this.siticoneShadowPanel1.Radius = 10;
            this.siticoneShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneShadowPanel1.ShadowDepth = 50;
            this.siticoneShadowPanel1.Size = new System.Drawing.Size(1177, 83);
            this.siticoneShadowPanel1.TabIndex = 0;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1193, 721);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.siticoneShadowPanel2);
            this.Controls.Add(this.siticoneShadowPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inventory";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.siticoneShadowPanel2.ResumeLayout(false);
            this.panelDropDown.ResumeLayout(false);
            this.siticoneShadowPanel1.ResumeLayout(false);
            this.siticoneShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.UI.WinForms.SiticoneShadowPanel siticoneShadowPanel2;
        private Siticone.UI.WinForms.SiticoneRoundedButton ReportBtn;
        private Siticone.UI.WinForms.SiticoneRoundedButton ProductBtn;
        private Siticone.UI.WinForms.SiticoneRoundedButton UserBtn;
        private AntdUI.In.FlowLayoutPanel panelDropDown;
        private Siticone.UI.WinForms.SiticoneRoundedButton SalesRBtn;
        private Siticone.UI.WinForms.SiticoneRoundedButton InventoryRBtn;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton7;
        private Siticone.UI.WinForms.SiticoneShadowPanel mainpanel;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private System.Windows.Forms.Timer dropDownTimer;
        private System.Windows.Forms.Timer loadingTimer;
        private System.Windows.Forms.Timer fadeTimer;
        private Siticone.UI.WinForms.SiticoneRoundedButton HomeBtn;
        private Siticone.UI.WinForms.SiticoneShadowPanel siticoneShadowPanel1;
    }
}