namespace CSCISystem
{
    partial class AddProduct
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
            this.siticoneShadowPanel3 = new Siticone.UI.WinForms.SiticoneShadowPanel();
            this.SuspendLayout();
            // 
            // siticoneShadowPanel3
            // 
            this.siticoneShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShadowPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneShadowPanel3.FillColor = System.Drawing.Color.White;
            this.siticoneShadowPanel3.Location = new System.Drawing.Point(0, 0);
            this.siticoneShadowPanel3.Name = "siticoneShadowPanel3";
            this.siticoneShadowPanel3.Radius = 10;
            this.siticoneShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.siticoneShadowPanel3.ShadowDepth = 50;
            this.siticoneShadowPanel3.Size = new System.Drawing.Size(858, 532);
            this.siticoneShadowPanel3.TabIndex = 4;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(145)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(858, 532);
            this.Controls.Add(this.siticoneShadowPanel3);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneShadowPanel siticoneShadowPanel3;
    }
}