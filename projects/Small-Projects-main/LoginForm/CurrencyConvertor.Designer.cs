namespace LoginForm
{
    partial class CurrencyConvertor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyConvertor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CboxInput = new System.Windows.Forms.ComboBox();
            this.CboxOutput = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnConvert);
            this.panel1.Controls.Add(this.txtOutput);
            this.panel1.Controls.Add(this.txtInput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CboxInput);
            this.panel1.Controls.Add(this.CboxOutput);
            this.panel1.Location = new System.Drawing.Point(10, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 92);
            this.panel1.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConvert.Location = new System.Drawing.Point(158, 63);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "CONVERT";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(206, 37);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(139, 20);
            this.txtOutput.TabIndex = 4;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(48, 37);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(133, 20);
            this.txtInput.TabIndex = 3;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // CboxInput
            // 
            this.CboxInput.FormattingEnabled = true;
            this.CboxInput.Items.AddRange(new object[] {
            "Euro",
            "MK Denar",
            "US Dolar"});
            this.CboxInput.Location = new System.Drawing.Point(61, 10);
            this.CboxInput.Name = "CboxInput";
            this.CboxInput.Size = new System.Drawing.Size(104, 21);
            this.CboxInput.TabIndex = 0;
            this.CboxInput.Text = "Convert From";
            this.CboxInput.SelectedIndexChanged += new System.EventHandler(this.CboxInput_SelectedIndexChanged);
            // 
            // CboxOutput
            // 
            this.CboxOutput.FormattingEnabled = true;
            this.CboxOutput.Items.AddRange(new object[] {
            "Euro",
            "MK Denar",
            "USD"});
            this.CboxOutput.Location = new System.Drawing.Point(222, 9);
            this.CboxOutput.Name = "CboxOutput";
            this.CboxOutput.Size = new System.Drawing.Size(106, 21);
            this.CboxOutput.TabIndex = 1;
            this.CboxOutput.Text = "Convert To";
            // 
            // CurrencyConvertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(425, 142);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CurrencyConvertor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Convertor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboxInput;
        private System.Windows.Forms.ComboBox CboxOutput;
    }
}