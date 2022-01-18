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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        a1: if (!Program.isOnForm)
            {
                Hide();
                Program.form1.ShowDialog();
            }
            if (!Program.isOnForm)
            {
                var dialogResult = MessageBox.Show("Qayta urunish uchunn (Retry/Пафтор),\nDasturdan chiqish uchun (Cancel/Отмена) tugmasini bosing!",
                    "Login yoki Parol xato!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Retry)
                    goto a1;
                else Application.Exit();
            }
            else
                Show();
        }

        private void TovarlarBtn_Click(object sender, EventArgs e)
        {
            Tovarlar tovarlar = new Tovarlar();
            Hide();
            tovarlar.ShowDialog();
            Show();
        }

        private void MijozlarBtn_Click(object sender, EventArgs e)
        {
            Mijozlar tovarlar = new Mijozlar();
            Hide();
            tovarlar.ShowDialog();
            Show();
        }
    }
}
