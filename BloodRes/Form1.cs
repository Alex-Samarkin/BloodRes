using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodRes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitResults();

            dataGridView1.DataSource = Results;
        }

        public List<Res> Results { get; set; } = new List<Res>();

        public void InitResults()
        {
            Res r = new Res();
            /// 1
            r.ID = 1;
            r.Title = "Glu";
            r.Nmin = 3.2;
            r.Nmax = 15;
            r.Value = 6.2;
            Results.Add(r);
            /// 2 
            r = new Res(){ID = 2, Title = "Hgb",Nmin=120,Nmax = 160,Value = 130};
            Results.Add(r);
            /// 3
            Results.Add(
                    new Res() { ID = 3, Title = "HDL", Nmin = 2, Nmax = 4.8, Value = 3 }
                    );
        }
    }
}
