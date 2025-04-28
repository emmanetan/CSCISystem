namespace CSCISystem
{
    partial class Login
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
            this.BtnInventory = new Siticone.UI.WinForms.SiticoneButton();
            this.BtnPOS = new Siticone.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // BtnInventory
            // 
            this.BtnInventory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnInventory.CheckedState.Parent = this.BtnInventory;
            this.BtnInventory.CustomImages.Parent = this.BtnInventory;
            this.BtnInventory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnInventory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnInventory.ForeColor = System.Drawing.Color.White;
            this.BtnInventory.HoveredState.Parent = this.BtnInventory;
            this.BtnInventory.Location = new System.Drawing.Point(103, 327);
            this.BtnInventory.Name = "BtnInventory";
            this.BtnInventory.ShadowDecoration.Parent = this.BtnInventory;
            this.BtnInventory.Size = new System.Drawing.Size(180, 45);
            this.BtnInventory.TabIndex = 0;
            this.BtnInventory.Text = "Inventory";
            this.BtnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // BtnPOS
            // 
            this.BtnPOS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPOS.CheckedState.Parent = this.BtnPOS;
            this.BtnPOS.CustomImages.Parent = this.BtnPOS;
            this.BtnPOS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnPOS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnPOS.ForeColor = System.Drawing.Color.White;
            this.BtnPOS.HoveredState.Parent = this.BtnPOS;
            this.BtnPOS.Location = new System.Drawing.Point(309, 327);
            this.BtnPOS.Name = "BtnPOS";
            this.BtnPOS.ShadowDecoration.Parent = this.BtnPOS;
            this.BtnPOS.Size = new System.Drawing.Size(180, 45);
            this.BtnPOS.TabIndex = 1;
            this.BtnPOS.Text = "POS";
            this.BtnPOS.Click += new System.EventHandler(this.BtnPOS_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 630);
            this.Controls.Add(this.BtnPOS);
            this.Controls.Add(this.BtnInventory);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneButton BtnInventory;
        private Siticone.UI.WinForms.SiticoneButton BtnPOS;
    }
}

