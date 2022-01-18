using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvtoMaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KirishBtn_Click(object sender, EventArgs e)
        {
            if (LogInTxt.Text.Length > 0 && ParolTxt.Text.Length > 0)
            { Program.isOnForm = true;}
            Close();
        }
    }
}
