using AvtoMaster.Yordamchi;
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
    public partial class Tovarlar : Form
    {
        public Tovarlar()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void Tovarlar_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
                tovarBindingSource1.Add(new Tovar()
                {
                    Id = i * i,
                    Nomi = "Moy " + i,
                    Turi = "zo'ridan",
                    Km = 11.500,
                    delete="O'chirish",
                    edit="Tahrirlash"
                });
        }
        private void TovarlarDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
