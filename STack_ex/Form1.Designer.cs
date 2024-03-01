namespace STack_ex
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            bntake = new Button();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 23);
            textBox1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(137, 96);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(64, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(340, 150);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // bntake
            // 
            bntake.Location = new Point(239, 96);
            bntake.Name = "bntake";
            bntake.Size = new Size(75, 23);
            bntake.TabIndex = 3;
            bntake.Text = "Take";
            bntake.UseVisualStyleBackColor = true;
            bntake.Click += bntake_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(462, 43);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 7;
            label1.Text = "Enter CD Name";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(451, 169);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(296, 150);
            dataGridView2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(590, 116);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(562, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 23);
            textBox2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(bntake);
            Controls.Add(dataGridView1);
            Controls.Add(btnAdd);
            Controls.Add(textBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private Button bntake;
        private Label label1;
        private DataGridView dataGridView2;
        private Button button1;
        private TextBox textBox2;
    }
}
