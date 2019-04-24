namespace Guia_1
{
    partial class formdll
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
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(54, 39);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(109, 58);
            this.Btn1.TabIndex = 0;
            this.Btn1.Text = "Apagar monitor";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(181, 39);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(115, 58);
            this.Btn2.TabIndex = 1;
            this.Btn2.Text = "Apagar monitor con tiempo";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(54, 124);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(75, 23);
            this.Btn3.TabIndex = 2;
            this.Btn3.Text = "Abrid CD";
            this.Btn3.UseVisualStyleBackColor = true;
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(181, 124);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(75, 23);
            this.Btn4.TabIndex = 3;
            this.Btn4.Text = "Cerrar CD";
            this.Btn4.UseVisualStyleBackColor = true;
            // 
            // formdll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 253);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Name = "formdll";
            this.Text = "formdll";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn4;
    }
}