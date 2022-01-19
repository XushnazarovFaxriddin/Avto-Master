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
    public partial class AddTovar : Form
    {
        public AddTovar()
        {
            InitializeComponent();
        }

        private void yaratishBtn_Click(object sender, EventArgs e)
        {
            bool isValidKM = double.TryParse(kmTxtBox.Text.ToLower().Replace(".", ",").Replace("km","").Replace(" ",""), out double km);
            if (nomiTxtBox.Text.Length < 4)
            {
                MessageBox.Show("Tovar nomi kamida 4 ta belgidan iborat bo'lishi shart!");
            } else if(turiTxtBox.Text.Length < 4)
            {
                MessageBox.Show("Tovar turi kamida 4 ta belgidan iborat bo'lishi shart!");
            }else if(!isValidKM)
            {
                MessageBox.Show("Necha KM masofa xizmat qilishi faqat haqiqiy sondan iborat bo'lishi shart!\n" +
                    "Masalan: 11,5 yoki 1250.7 yoki 6000 km");
            }
            else
            {
                MessageBox.Show("Hammasi joyida :)");
            }
        }
    }
}
