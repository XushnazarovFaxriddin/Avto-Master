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
    public partial class Mijozlar : Form
    {
        public Mijozlar()
        {
            InitializeComponent();
        }

        private void Mijozlar_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
                mijozBindingSource.Add(new Mijoz()
                {
                    Id = i,
                    FIO = $"Faxriddin{i} Xushnazarov{i} Farhod o'gli{i}",
                    Tel=$"+9989{i}-683-15-55",
                    AvtomobileNomi="Matiz "+i,
                    AvtomobileRaqami="80 W 30"+i+" DA",
                    tovar=i.ToString(),
                    olganVaqti="12.02.2021",
                    TugashVaqti="11.02.2022",
                    delete="O'chirish",
                    edit="Tahrirlash"
                });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
