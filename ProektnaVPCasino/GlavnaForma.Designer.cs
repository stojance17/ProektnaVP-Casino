﻿namespace SameFormTest
{
    partial class GlavnaForma
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pariZaSlednaIgra = new System.Windows.Forms.TextBox();
            this.vkPari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 84);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start Hi-Low Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kazino";
            // 
            // pariZaSlednaIgra
            // 
            this.pariZaSlednaIgra.Location = new System.Drawing.Point(345, 327);
            this.pariZaSlednaIgra.Name = "pariZaSlednaIgra";
            this.pariZaSlednaIgra.Size = new System.Drawing.Size(118, 20);
            this.pariZaSlednaIgra.TabIndex = 4;
            // 
            // vkPari
            // 
            this.vkPari.Location = new System.Drawing.Point(653, 418);
            this.vkPari.Name = "vkPari";
            this.vkPari.Size = new System.Drawing.Size(100, 20);
            this.vkPari.TabIndex = 5;
            this.vkPari.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vkupno pari";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pari za sledna igra";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vkPari);
            this.Controls.Add(this.pariZaSlednaIgra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pariZaSlednaIgra;
        private System.Windows.Forms.TextBox vkPari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}