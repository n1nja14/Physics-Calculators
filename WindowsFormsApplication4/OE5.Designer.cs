﻿namespace WindowsFormsApplication4
{
    partial class OE5
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
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 90);
            this.button2.TabIndex = 20;
            this.button2.Text = "Далее";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(83, 348);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(193, 29);
            this.radioButton4.TabIndex = 19;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4) Напряжение";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(83, 291);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(285, 29);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3) Электрический заряд";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(83, 234);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(224, 29);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2) Сопротивление";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(83, 177);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(170, 29);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1) Сила тока";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(767, 50);
            this.label1.TabIndex = 15;
            this.label1.Text = "5. Укажите, какая физическая величина одинакова для всех проводников, \r\nсоединённ" +
    "ых параллельно?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 90);
            this.button1.TabIndex = 14;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(83, 405);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(171, 29);
            this.radioButton5.TabIndex = 21;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5) Мощность";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // OE5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 654);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 725);
            this.MinimumSize = new System.Drawing.Size(950, 725);
            this.Name = "OE5";
            this.Text = "Тест на тему Электродинамика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton5;
    }
}