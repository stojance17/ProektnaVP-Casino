namespace SameFormTest
{
    partial class HiLowForm
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
            this.components = new System.ComponentModel.Container();
            this.btnHi = new System.Windows.Forms.Button();
            this.btnLow = new System.Windows.Forms.Button();
            this.pogodeni = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picBoxCurr = new System.Windows.Forms.PictureBox();
            this.picBoxNext = new System.Windows.Forms.PictureBox();
            this.pari = new System.Windows.Forms.TextBox();
            this.betTip = new System.Windows.Forms.NumericUpDown();
            this.cashOutbtn = new System.Windows.Forms.Button();
            this.cashOutAmount = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.endGamebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCurr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betTip)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHi
            // 
            this.btnHi.Location = new System.Drawing.Point(346, 98);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(75, 23);
            this.btnHi.TabIndex = 1;
            this.btnHi.Text = "Hi";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // btnLow
            // 
            this.btnLow.Location = new System.Drawing.Point(346, 165);
            this.btnLow.Name = "btnLow";
            this.btnLow.Size = new System.Drawing.Size(75, 23);
            this.btnLow.TabIndex = 2;
            this.btnLow.Text = "Low";
            this.btnLow.UseVisualStyleBackColor = true;
            this.btnLow.Click += new System.EventHandler(this.btnLow_Click);
            // 
            // pogodeni
            // 
            this.pogodeni.AutoSize = true;
            this.pogodeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pogodeni.Location = new System.Drawing.Point(353, 316);
            this.pogodeni.Name = "pogodeni";
            this.pogodeni.Size = new System.Drawing.Size(68, 73);
            this.pogodeni.TabIndex = 5;
            this.pogodeni.Text = "0";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // picBoxCurr
            // 
            this.picBoxCurr.Image = global::SameFormTest.Properties.Resources.hearts_7;
            this.picBoxCurr.InitialImage = global::SameFormTest.Properties.Resources.hearts_7;
            this.picBoxCurr.Location = new System.Drawing.Point(126, 41);
            this.picBoxCurr.Name = "picBoxCurr";
            this.picBoxCurr.Size = new System.Drawing.Size(143, 197);
            this.picBoxCurr.TabIndex = 6;
            this.picBoxCurr.TabStop = false;
            // 
            // picBoxNext
            // 
            this.picBoxNext.InitialImage = global::SameFormTest.Properties.Resources.hearts_7;
            this.picBoxNext.Location = new System.Drawing.Point(501, 41);
            this.picBoxNext.Name = "picBoxNext";
            this.picBoxNext.Size = new System.Drawing.Size(143, 197);
            this.picBoxNext.TabIndex = 7;
            this.picBoxNext.TabStop = false;
            // 
            // pari
            // 
            this.pari.Enabled = false;
            this.pari.Location = new System.Drawing.Point(146, 413);
            this.pari.Name = "pari";
            this.pari.ReadOnly = true;
            this.pari.Size = new System.Drawing.Size(48, 20);
            this.pari.TabIndex = 8;
            this.pari.Text = "100";
            // 
            // betTip
            // 
            this.betTip.Location = new System.Drawing.Point(201, 414);
            this.betTip.Name = "betTip";
            this.betTip.Size = new System.Drawing.Size(58, 20);
            this.betTip.TabIndex = 9;
            // 
            // cashOutbtn
            // 
            this.cashOutbtn.Location = new System.Drawing.Point(534, 410);
            this.cashOutbtn.Name = "cashOutbtn";
            this.cashOutbtn.Size = new System.Drawing.Size(75, 23);
            this.cashOutbtn.TabIndex = 10;
            this.cashOutbtn.Text = "Cash OUT";
            this.cashOutbtn.UseVisualStyleBackColor = true;
            this.cashOutbtn.Click += new System.EventHandler(this.cashOutbtn_Click);
            // 
            // cashOutAmount
            // 
            this.cashOutAmount.Enabled = false;
            this.cashOutAmount.Location = new System.Drawing.Point(470, 412);
            this.cashOutAmount.Name = "cashOutAmount";
            this.cashOutAmount.ReadOnly = true;
            this.cashOutAmount.Size = new System.Drawing.Size(48, 20);
            this.cashOutAmount.TabIndex = 11;
            this.cashOutAmount.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // endGamebtn
            // 
            this.endGamebtn.Location = new System.Drawing.Point(12, 267);
            this.endGamebtn.Name = "endGamebtn";
            this.endGamebtn.Size = new System.Drawing.Size(98, 86);
            this.endGamebtn.TabIndex = 12;
            this.endGamebtn.Text = "END GAME";
            this.endGamebtn.UseVisualStyleBackColor = true;
            this.endGamebtn.Click += new System.EventHandler(this.endGamebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 441);
            this.Controls.Add(this.endGamebtn);
            this.Controls.Add(this.cashOutAmount);
            this.Controls.Add(this.cashOutbtn);
            this.Controls.Add(this.betTip);
            this.Controls.Add(this.pari);
            this.Controls.Add(this.picBoxNext);
            this.Controls.Add(this.picBoxCurr);
            this.Controls.Add(this.pogodeni);
            this.Controls.Add(this.btnLow);
            this.Controls.Add(this.btnHi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCurr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betTip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHi;
        private System.Windows.Forms.Button btnLow;
        private System.Windows.Forms.Label pogodeni;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picBoxCurr;
        private System.Windows.Forms.PictureBox picBoxNext;
        private System.Windows.Forms.TextBox pari;
        private System.Windows.Forms.NumericUpDown betTip;
        private System.Windows.Forms.Button cashOutbtn;
        private System.Windows.Forms.TextBox cashOutAmount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button endGamebtn;
    }
}

