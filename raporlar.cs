using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goz_klinigi
{
    public partial class raporlar : Form
    {
        Göz_kliniğiEntities db = new Göz_kliniğiEntities();
        public raporlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ODEMEs.Where(x => x.odemeSekli== "nakit").ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ODEMEs.Where(x => x.odemeSekli == "taksit").ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.RANDEVUs.Where(x => x.randevuNedeni == "muayene").ToList();
        }
    }
}
