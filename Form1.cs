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
    public partial class Form1 : Form
    {
        Göz_kliniğiEntities db = new Göz_kliniğiEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res= db.DOKTORs.Where(x => x.doktorAdi == textName.Text && x.sifre==textPass.Text).ToList();
            if(res.Count()>0)
            {
                raporlar rp = new raporlar();
                rp.Show();
            }

            else
            {
                MessageBox.Show("user name or password invalid");
            }
            
            
        }
    }
}
