namespace Degrees_Convertor
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
            this.CelToFahr = new System.Windows.Forms.RadioButton();
            this.FahrToCel = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Convert = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CelToFahr
            // 
            this.CelToFahr.AutoSize = true;
            this.CelToFahr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelToFahr.Location = new System.Drawing.Point(102, 120);
            this.CelToFahr.Name = "CelToFahr";
            this.CelToFahr.Size = new System.Drawing.Size(191, 24);
            this.CelToFahr.TabIndex = 0;
            this.CelToFahr.TabStop = true;
            this.CelToFahr.Text = "Celsius To Fahrenheit";
            this.CelToFahr.UseVisualStyleBackColor = true;
            // 
            // FahrToCel
            // 
            this.FahrToCel.AutoSize = true;
            this.FahrToCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FahrToCel.Location = new System.Drawing.Point(102, 165);
            this.FahrToCel.Name = "FahrToCel";
            this.FahrToCel.Size = new System.Drawing.Size(191, 24);
            this.FahrToCel.TabIndex = 1;
            this.FahrToCel.TabStop = true;
            this.FahrToCel.Text = "Fahrenheit To Celsius";
            this.FahrToCel.UseVisualStyleBackColor = true;
            this.FahrToCel.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Degrees Convertor";
            // 
            // Convert
            // 
            this.Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert.Location = new System.Drawing.Point(113, 261);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(167, 43);
            this.Convert.TabIndex = 3;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(130, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(412, 369);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FahrToCel);
            this.Controls.Add(this.CelToFahr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton CelToFahr;
        private System.Windows.Forms.RadioButton FahrToCel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.TextBox textBox1;
    }
}

