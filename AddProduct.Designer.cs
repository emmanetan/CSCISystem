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
            this.input1 = new AntdUI.Input();
            this.input2 = new AntdUI.Input();
            this.input4 = new AntdUI.Input();
            this.inputNumber1 = new AntdUI.InputNumber();
            this.uploadDragger1 = new AntdUI.UploadDragger();
            this.panel1 = new AntdUI.Panel();
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.button1 = new AntdUI.Button();
            this.siticoneShadowPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneShadowPanel3
            // 
            this.siticoneShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShadowPanel3.Controls.Add(this.button1);
            this.siticoneShadowPanel3.Controls.Add(this.panel1);
            this.siticoneShadowPanel3.Controls.Add(this.inputNumber1);
            this.siticoneShadowPanel3.Controls.Add(this.input4);
            this.siticoneShadowPanel3.Controls.Add(this.input2);
            this.siticoneShadowPanel3.Controls.Add(this.input1);
            this.siticoneShadowPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneShadowPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.siticoneShadowPanel3.Location = new System.Drawing.Point(0, 0);
            this.siticoneShadowPanel3.Name = "siticoneShadowPanel3";
            this.siticoneShadowPanel3.Radius = 10;
            this.siticoneShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.siticoneShadowPanel3.ShadowDepth = 50;
            this.siticoneShadowPanel3.Size = new System.Drawing.Size(858, 532);
            this.siticoneShadowPanel3.TabIndex = 4;
            // 
            // input1
            // 
            this.input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(114, 88);
            this.input1.Name = "input1";
            this.input1.PlaceholderText = "Item Code";
            this.input1.Radius = 50;
            this.input1.Size = new System.Drawing.Size(204, 59);
            this.input1.TabIndex = 0;
            // 
            // input2
            // 
            this.input2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input2.Location = new System.Drawing.Point(114, 169);
            this.input2.Name = "input2";
            this.input2.PlaceholderText = "Item Name";
            this.input2.Radius = 50;
            this.input2.Size = new System.Drawing.Size(204, 59);
            this.input2.TabIndex = 1;
            // 
            // input4
            // 
            this.input4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input4.Location = new System.Drawing.Point(114, 328);
            this.input4.Name = "input4";
            this.input4.PlaceholderText = "Price";
            this.input4.Radius = 50;
            this.input4.Size = new System.Drawing.Size(204, 59);
            this.input4.TabIndex = 3;
            // 
            // inputNumber1
            // 
            this.inputNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNumber1.Location = new System.Drawing.Point(114, 250);
            this.inputNumber1.Name = "inputNumber1";
            this.inputNumber1.PlaceholderText = "Qty";
            this.inputNumber1.Radius = 50;
            this.inputNumber1.Size = new System.Drawing.Size(204, 59);
            this.inputNumber1.TabIndex = 5;
            // 
            // uploadDragger1
            // 
            this.uploadDragger1.IconRatio = 3F;
            this.uploadDragger1.Location = new System.Drawing.Point(26, 181);
            this.uploadDragger1.Name = "uploadDragger1";
            this.uploadDragger1.Size = new System.Drawing.Size(227, 99);
            this.uploadDragger1.TabIndex = 6;
            this.uploadDragger1.Text = "Upload Image";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.siticonePanel1);
            this.panel1.Controls.Add(this.uploadDragger1);
            this.panel1.Location = new System.Drawing.Point(482, 88);
            this.panel1.Name = "panel1";
            this.panel1.ShadowOpacityHover = 1F;
            this.panel1.Size = new System.Drawing.Size(269, 299);
            this.panel1.TabIndex = 7;
            this.panel1.Text = "panel1";
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Location = new System.Drawing.Point(26, 28);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(227, 131);
            this.siticonePanel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 532);
            this.Controls.Add(this.siticoneShadowPanel3);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.siticoneShadowPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneShadowPanel siticoneShadowPanel3;
        private AntdUI.Input input4;
        private AntdUI.Input input2;
        private AntdUI.Input input1;
        private AntdUI.InputNumber inputNumber1;
        private AntdUI.UploadDragger uploadDragger1;
        private AntdUI.Panel panel1;
        private AntdUI.Button button1;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
    }
}