using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STack_ex
{
    public partial class SearchCD : Form
    {
        Stack<CD> allcd;
        public SearchCD()
        {
            InitializeComponent();
        }

        private void SearchCD_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
           
        }
    }
}
