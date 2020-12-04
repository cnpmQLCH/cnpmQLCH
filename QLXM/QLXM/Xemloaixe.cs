using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXM
{
    public partial class Xemloaixe : Form
    {
        public Xemloaixe()
        {
            InitializeComponent();
        }

        QLXMEntities qlxm = new QLXMEntities();
        

        private void Xemloaixe_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = qlxm.Loaixes.ToList();
            dataGridView1.Columns[2].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimkiemXe s = new TimkiemXe();
            s.Show();
        }
    }
}
