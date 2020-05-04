namespace Spencers_QR_Code_Generator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxQRCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            this.comboBoxECC = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconSize = new System.Windows.Forms.NumericUpDown();
            this.labelIconsize = new System.Windows.Forms.Label();
            this.iconPath = new System.Windows.Forms.TextBox();
            this.labelIcon = new System.Windows.Forms.Label();
            this.selectIconBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSize)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(445, 479);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 38);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxQRCode
            // 
            this.textBoxQRCode.Location = new System.Drawing.Point(106, 21);
            this.textBoxQRCode.Name = "textBoxQRCode";
            this.textBoxQRCode.Size = new System.Drawing.Size(431, 20);
            this.textBoxQRCode.TabIndex = 2;
            this.textBoxQRCode.Text = "http://www.";
            this.textBoxQRCode.TextChanged += new System.EventHandler(this.textBoxQRCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Web Page:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxQRCode);
            this.groupBox1.Location = new System.Drawing.Point(14, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 408);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(381, 381);
            this.pictureBoxQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxQRCode.TabIndex = 0;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // comboBoxECC
            // 
            this.comboBoxECC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxECC.FormattingEnabled = true;
            this.comboBoxECC.Items.AddRange(new object[] {
            "L",
            "M",
            "Q",
            "H"});
            this.comboBoxECC.Location = new System.Drawing.Point(131, 51);
            this.comboBoxECC.Name = "comboBoxECC";
            this.comboBoxECC.Size = new System.Drawing.Size(50, 21);
            this.comboBoxECC.TabIndex = 5;
            this.comboBoxECC.SelectedIndexChanged += new System.EventHandler(this.comboBoxECC_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Error Correction Level:";
            // 
            // iconSize
            // 
            this.iconSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconSize.Location = new System.Drawing.Point(480, 79);
            this.iconSize.Name = "iconSize";
            this.iconSize.Size = new System.Drawing.Size(57, 20);
            this.iconSize.TabIndex = 13;
            this.iconSize.ValueChanged += new System.EventHandler(this.iconSize_ValueChanged);
            // 
            // labelIconsize
            // 
            this.labelIconsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIconsize.AutoSize = true;
            this.labelIconsize.Location = new System.Drawing.Point(422, 87);
            this.labelIconsize.Name = "labelIconsize";
            this.labelIconsize.Size = new System.Drawing.Size(52, 13);
            this.labelIconsize.TabIndex = 12;
            this.labelIconsize.Text = "Icon size:";
            // 
            // iconPath
            // 
            this.iconPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconPath.Location = new System.Drawing.Point(246, 53);
            this.iconPath.Name = "iconPath";
            this.iconPath.ReadOnly = true;
            this.iconPath.Size = new System.Drawing.Size(291, 20);
            this.iconPath.TabIndex = 11;
            // 
            // labelIcon
            // 
            this.labelIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIcon.AutoSize = true;
            this.labelIcon.Location = new System.Drawing.Point(209, 60);
            this.labelIcon.Name = "labelIcon";
            this.labelIcon.Size = new System.Drawing.Size(31, 13);
            this.labelIcon.TabIndex = 10;
            this.labelIcon.Text = "Icon:";
            // 
            // selectIconBtn
            // 
            this.selectIconBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectIconBtn.Location = new System.Drawing.Point(14, 82);
            this.selectIconBtn.Name = "selectIconBtn";
            this.selectIconBtn.Size = new System.Drawing.Size(78, 21);
            this.selectIconBtn.TabIndex = 14;
            this.selectIconBtn.Text = "Select Icon";
            this.selectIconBtn.UseVisualStyleBackColor = true;
            this.selectIconBtn.Click += new System.EventHandler(this.selectIconBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 529);
            this.Controls.Add(this.selectIconBtn);
            this.Controls.Add(this.iconSize);
            this.Controls.Add(this.labelIconsize);
            this.Controls.Add(this.iconPath);
            this.Controls.Add(this.labelIcon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxECC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQRCode);
            this.Controls.Add(this.buttonSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Spencer\'s QR Code Generator";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxQRCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
        private System.Windows.Forms.ComboBox comboBoxECC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown iconSize;
        private System.Windows.Forms.Label labelIconsize;
        private System.Windows.Forms.TextBox iconPath;
        private System.Windows.Forms.Label labelIcon;
        private System.Windows.Forms.Button selectIconBtn;
    }
}

