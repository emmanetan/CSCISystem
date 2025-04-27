namespace CSCISystem
{
    partial class InventoryReport
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
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneShadowPanel3 = new Siticone.UI.WinForms.SiticoneShadowPanel();
            this.siticoneShadowPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(145)))), ((int)(((byte)(134)))));
            this.siticoneLabel1.Location = new System.Drawing.Point(45, 32);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(164, 30);
            this.siticoneLabel1.TabIndex = 0;
            this.siticoneLabel1.Text = "Inventory Report";
            // 
            // siticoneShadowPanel3
            // 
            this.siticoneShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShadowPanel3.Controls.Add(this.siticoneLabel1);
            this.siticoneShadowPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneShadowPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.siticoneShadowPanel3.Location = new System.Drawing.Point(0, 0);
            this.siticoneShadowPanel3.Name = "siticoneShadowPanel3";
            this.siticoneShadowPanel3.Radius = 10;
            this.siticoneShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.siticoneShadowPanel3.ShadowDepth = 50;
            this.siticoneShadowPanel3.Size = new System.Drawing.Size(855, 599);
            this.siticoneShadowPanel3.TabIndex = 4;
            // 
            // InventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(145)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(855, 599);
            this.Controls.Add(this.siticoneShadowPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryReport";
            this.Text = "InventoryReport";
            this.siticoneShadowPanel3.ResumeLayout(false);
            this.siticoneShadowPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Siticone.UI.WinForms.SiticoneShadowPanel siticoneShadowPanel3;
    }
}