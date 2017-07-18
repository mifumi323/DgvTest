using System;
using System.Windows.Forms;

namespace DgvTest {
    public partial class Form1:Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender,EventArgs e) {
            dataGridView1.Rows.Add(1000);
        }

        private void button2_Click(object sender,EventArgs e) {
            var start = DateTime.Now;
            var max = this.dataGridView1.RowCount;
            dataGridView1.Rows.Clear();
            MessageBox.Show(max + "行削除に" + (DateTime.Now - start) + "かかった");
        }

        private void button3_Click(object sender,EventArgs e) {
            var start = DateTime.Now;
            var max = this.dataGridView1.RowCount;
            if(this.dataGridView1.AllowUserToAddRows) max--;
            for(var i = 0;i < max;i++) this.dataGridView1.Rows.RemoveAt(0);
            MessageBox.Show(max + "行削除に" + (DateTime.Now - start) + "かかった");
        }
    }
}
