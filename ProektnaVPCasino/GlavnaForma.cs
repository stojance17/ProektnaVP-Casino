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
        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Pravi proverki dali ima dovolno pari i dali e korekten inputot za da nema exception
            if (pariZaSlednaIgra.Text == "")
            {
                MessageBox.Show("Vnesete suma za sledna igra");
                return;
            }
            else if (int.Parse(pariZaSlednaIgra.Text) <= 0)
            {
                return;
            }
            else if (int.Parse(pariZaSlednaIgra.Text) > int.Parse(vkPari.Text))
            {
                MessageBox.Show("Nemate tolku pari");
                return;
            }

            //Odzima suma od vkupnata
            vkPari.Text = (int.Parse(vkPari.Text) - int.Parse(pariZaSlednaIgra.Text)).ToString();

            // #1. Make second form
            // If you want to make equivalent one, then change Form2 -> Form1
            HiLowForm HiLowForm1 = new HiLowForm(int.Parse(pariZaSlednaIgra.Text));

            // #2. Set second form's size
            HiLowForm1.Width = this.Width;
            HiLowForm1.Height = this.Height;

            // #3. Set second form's start position as same as parent form
            HiLowForm1.StartPosition = FormStartPosition.Manual;
            HiLowForm1.Location = new Point(this.Location.X, this.Location.Y);

            // #4. Set parent form's visible to false
            this.Visible = false;

            // #5. Open second dialog
            HiLowForm1.ShowDialog();

            //Ja vrakja vrednosta osvoena/izgubena od igrata
            vkPari.Text = (int.Parse(vkPari.Text) + HiLowForm1.cashOutMoney).ToString();

            // #6. Set parent form's visible to true
            this.Visible = true;
        }
    }
}