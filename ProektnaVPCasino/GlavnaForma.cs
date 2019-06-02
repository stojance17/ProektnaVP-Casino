﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SameFormTest
{ 
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
            vkupnoPari = 0;
        }
        private int vkupnoPari { get; set; }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            povikajHiLow();
          
        }
        private void povikajHiLow()
        {
            if (proverkaPari())
            {
                vkupnoPari = vkupnoPari - int.Parse(pariZaSlednaIgra.Text);
                HiLowForm HiLowForm1 = new HiLowForm(int.Parse(pariZaSlednaIgra.Text));
                HiLowForm1.Width = this.Width;
                HiLowForm1.Height = this.Height;
                HiLowForm1.StartPosition = FormStartPosition.Manual;
                HiLowForm1.Location = new Point(this.Location.X, this.Location.Y);
                this.Visible = false;
                HiLowForm1.ShowDialog();
                vkupnoPari = vkupnoPari + HiLowForm1.cashOutMoney;
                update();
                this.Location = HiLowForm1.Location;
                this.Width = HiLowForm1.Width;
                this.Height = HiLowForm1.Height;
                this.Visible = true;
            }
        }

        private bool proverkaPari()
        {
            //Pravi proverki dali ima dovolno pari i dali e korekten inputot za da nema exception
            if (pariZaSlednaIgra.Text == "" || int.Parse(pariZaSlednaIgra.Text) == 0)
            {
                MessageBox.Show("Vnesete validna suma za sledna igra");
                return false;
            }
            else if (int.Parse(pariZaSlednaIgra.Text) > vkupnoPari)
            {
                MessageBox.Show("Nemate tolku pari");
                return false;
            }
            else return true;
        }

        private void uplatiPari_Click(object sender, EventArgs e)
        {
            UplataPariForm form = new UplataPariForm();
            DialogResult result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                vkupnoPari = form.suma;
                update();
            }
        }
        private void update()
        {
            vkPari.Text = vkupnoPari.ToString();
        }


        private void GlavnaForma_Load(object sender, EventArgs e)
        {

        }
    }
}
