namespace Praktinis2._2
{
    partial class Krepselis
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(430, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 34);
            this.button2.TabIndex = 41;
            this.button2.Text = "Apmoketi viska";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 41);
            this.button1.TabIndex = 40;
            this.button1.Text = "Apmoketi pasirinkta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(141, 122);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(269, 225);
            this.listBox3.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Pavadinimas/Kiekis/Kaina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 29);
            this.label4.TabIndex = 37;
            this.label4.Text = "Mano Krepselis";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(430, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 34);
            this.button3.TabIndex = 42;
            this.button3.Text = "Istrinti pasirinkta";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(430, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 34);
            this.button4.TabIndex = 43;
            this.button4.Text = "Istrinti viska";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Krepselis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "Krepselis";
            this.Size = new System.Drawing.Size(639, 382);
            this.Load += new System.EventHandler(this.Krepselis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
