namespace CSCISystem
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.siticoneShadowPanel3 = new Siticone.UI.WinForms.SiticoneShadowPanel();
            this.ButtonAddProd = new AntdUI.Button();
            this.siticoneShadowPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneShadowPanel3
            // 
            this.siticoneShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShadowPanel3.Controls.Add(this.ButtonAddProd);
            this.siticoneShadowPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneShadowPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.siticoneShadowPanel3.Location = new System.Drawing.Point(0, 0);
            this.siticoneShadowPanel3.Name = "siticoneShadowPanel3";
            this.siticoneShadowPanel3.Radius = 10;
            this.siticoneShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.siticoneShadowPanel3.ShadowDepth = 50;
            this.siticoneShadowPanel3.Size = new System.Drawing.Size(855, 599);
            this.siticoneShadowPanel3.TabIndex = 3;
            // 
            // ButtonAddProd
            // 
            this.ButtonAddProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddProd.BackgroundImageLayout = AntdUI.TFit.Contain;
            this.ButtonAddProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(73)))));
            this.ButtonAddProd.Icon = ((System.Drawing.Image)(resources.GetObject("ButtonAddProd.Icon")));
            this.ButtonAddProd.IconRatio = 1F;
            this.ButtonAddProd.IconSize = new System.Drawing.Size(20, 20);
            this.ButtonAddProd.Location = new System.Drawing.Point(737, 22);
            this.ButtonAddProd.Name = "ButtonAddProd";
            this.ButtonAddProd.Radius = 50;
            this.ButtonAddProd.Size = new System.Drawing.Size(95, 43);
            this.ButtonAddProd.TabIndex = 1;
            this.ButtonAddProd.WaveSize = 0;
            this.ButtonAddProd.Click += new System.EventHandler(this.ButtonAddProd_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(145)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(855, 599);
            this.Controls.Add(this.siticoneShadowPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.Text = "Product";
            this.siticoneShadowPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneShadowPanel siticoneShadowPanel3;
        private AntdUI.Button ButtonAddProd;
    }
}