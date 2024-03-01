namespace STack_ex
{

    public partial class Form1 : Form
    {
        Stack<CD> allcd;
        public Form1()
        {
            InitializeComponent();
            allcd = new Stack<CD>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var d = this.allcd.Any(c => c.Name.Equals(this.textBox1.Text));
            if (!d)
            {
                this.allcd.Push(new CD { Id = allcd.Count + 1, Name = this.textBox1.Text });
                this.dataGridView1.DataSource = allcd.ToList();
            }
            else
            {
                MessageBox.Show("Already exist");
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bntake_Click(object sender, EventArgs e)
        {
            if (this.allcd.Count() > 0)
            {
                this.allcd.Pop();
                this.dataGridView1.DataSource = this.allcd.ToList();
            }
            else
            {
                MessageBox.Show("Allready you took all cd ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.allcd.Count > 0)
            {
                var result= this.allcd.Where(c => c.Name.ToLower().Equals(this.textBox2.Text.ToLower())).AsQueryable();
                this.dataGridView2.DataSource= result.ToList();
            }
            else
            {
                MessageBox.Show("There is no CD to search ");
            }
        }
    }
}
