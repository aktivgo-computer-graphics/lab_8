namespace lab_8
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
            this.button = new System.Windows.Forms.Button();
            this.textBoxP1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxP2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxP3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxP4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(12, 140);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(138, 33);
            this.button.TabIndex = 0;
            this.button.Text = "Нарисовать";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // textBoxP1
            // 
            this.textBoxP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxP1.Location = new System.Drawing.Point(50, 12);
            this.textBoxP1.Name = "textBoxP1";
            this.textBoxP1.Size = new System.Drawing.Size(100, 26);
            this.textBoxP1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "P1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "P2";
            // 
            // textBoxP2
            // 
            this.textBoxP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxP2.Location = new System.Drawing.Point(50, 44);
            this.textBoxP2.Name = "textBoxP2";
            this.textBoxP2.Size = new System.Drawing.Size(100, 26);
            this.textBoxP2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "P3";
            // 
            // textBoxP3
            // 
            this.textBoxP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxP3.Location = new System.Drawing.Point(50, 76);
            this.textBoxP3.Name = "textBoxP3";
            this.textBoxP3.Size = new System.Drawing.Size(100, 26);
            this.textBoxP3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "P4";
            // 
            // textBoxP4
            // 
            this.textBoxP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxP4.Location = new System.Drawing.Point(50, 108);
            this.textBoxP4.Name = "textBoxP4";
            this.textBoxP4.Size = new System.Drawing.Size(100, 26);
            this.textBoxP4.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxP4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxP3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxP2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxP1);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "Кривая Безье";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxP1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxP2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxP3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxP4;

        private System.Windows.Forms.Button button;

        #endregion
    }
}