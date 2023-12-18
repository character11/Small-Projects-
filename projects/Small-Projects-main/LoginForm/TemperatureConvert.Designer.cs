namespace LoginForm
{
    partial class TemperatureConvert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemperatureConvert));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnFC = new System.Windows.Forms.RadioButton();
            this.rbtnCF = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFar = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.rbtnFC);
            this.groupBox1.Controls.Add(this.rbtnCF);
            this.groupBox1.Location = new System.Drawing.Point(25, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose one option";
            // 
            // rbtnFC
            // 
            this.rbtnFC.AutoSize = true;
            this.rbtnFC.Location = new System.Drawing.Point(22, 44);
            this.rbtnFC.Name = "rbtnFC";
            this.rbtnFC.Size = new System.Drawing.Size(53, 17);
            this.rbtnFC.TabIndex = 1;
            this.rbtnFC.TabStop = true;
            this.rbtnFC.Text = "F to C";
            this.rbtnFC.UseVisualStyleBackColor = true;
            this.rbtnFC.CheckedChanged += new System.EventHandler(this.rbtnFC_CheckedChanged);
            // 
            // rbtnCF
            // 
            this.rbtnCF.AutoSize = true;
            this.rbtnCF.Location = new System.Drawing.Point(22, 20);
            this.rbtnCF.Name = "rbtnCF";
            this.rbtnCF.Size = new System.Drawing.Size(53, 17);
            this.rbtnCF.TabIndex = 0;
            this.rbtnCF.TabStop = true;
            this.rbtnCF.Text = "C to F";
            this.rbtnCF.UseVisualStyleBackColor = true;
            this.rbtnCF.CheckedChanged += new System.EventHandler(this.rbtnCF_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtFar);
            this.groupBox2.Controls.Add(this.txtCel);
            this.groupBox2.Location = new System.Drawing.Point(25, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 108);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preform Conversions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fahrenheit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Celsius";
            // 
            // txtFar
            // 
            this.txtFar.Location = new System.Drawing.Point(209, 61);
            this.txtFar.Name = "txtFar";
            this.txtFar.Size = new System.Drawing.Size(100, 20);
            this.txtFar.TabIndex = 1;
            this.txtFar.TextChanged += new System.EventHandler(this.txtFar_TextChanged);
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(29, 61);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(100, 20);
            this.txtCel.TabIndex = 0;
            this.txtCel.TextChanged += new System.EventHandler(this.txtCel_TextChanged);
            // 
            // TemperatureConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(387, 266);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TemperatureConvert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Celsius | Fahrenheit Convertor";
            this.Load += new System.EventHandler(this.TemperatureConvert_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnFC;
        private System.Windows.Forms.RadioButton rbtnCF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFar;
        private System.Windows.Forms.TextBox txtCel;
    }
}