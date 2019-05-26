namespace SameFormTest
{
    partial class UplataPariForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.sumaNud = new System.Windows.Forms.NumericUpDown();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CANCELBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sumaNud)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vnesete Ja Vashata Suma";
            // 
            // sumaNud
            // 
            this.sumaNud.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumaNud.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sumaNud.Location = new System.Drawing.Point(69, 123);
            this.sumaNud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.sumaNud.Name = "sumaNud";
            this.sumaNud.Size = new System.Drawing.Size(192, 31);
            this.sumaNud.TabIndex = 1;
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(186, 224);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(123, 42);
            this.OKBtn.TabIndex = 2;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CANCELBtn
            // 
            this.CANCELBtn.Location = new System.Drawing.Point(12, 224);
            this.CANCELBtn.Name = "CANCELBtn";
            this.CANCELBtn.Size = new System.Drawing.Size(123, 42);
            this.CANCELBtn.TabIndex = 3;
            this.CANCELBtn.Text = "Cancel";
            this.CANCELBtn.UseVisualStyleBackColor = true;
            this.CANCELBtn.Click += new System.EventHandler(this.CANCELBtn_Click);
            // 
            // UplataPariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 278);
            this.Controls.Add(this.CANCELBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.sumaNud);
            this.Controls.Add(this.label1);
            this.Name = "UplataPariForm";
            this.Text = "UplataPariForm";
            ((System.ComponentModel.ISupportInitialize)(this.sumaNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown sumaNud;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CANCELBtn;
    }
}