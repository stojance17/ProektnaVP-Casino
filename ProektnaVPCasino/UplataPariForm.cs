using System;
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
    public partial class UplataPariForm : Form
    {
        public int suma { get; set; }
        public UplataPariForm()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            suma = (int)sumaNud.Value;
            GlavnaForma form1 = Parent as GlavnaForma;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void CANCELBtn_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
