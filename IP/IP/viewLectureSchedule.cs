using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP.ServiceReference1;

namespace IP
{
    public partial class viewLectureSchedule : Form
    {
        public viewLectureSchedule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataRowView bid = (DataRowView)comboBox1.SelectedItem;
            string batch = bid.Row.ItemArray[0].ToString();


            DataRowView mid = (DataRowView)comboBox2.SelectedItem;
            string mod = mid.Row.ItemArray[0].ToString();

            Service1Client obj = new Service1Client();
          dataGridView1.DataSource=  obj.viewLectureSchedule(batch,mod);


        }

        private void viewLectureSchedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resourceAllocationDataSet14.Modules' table. You can move, or remove it, as needed.
            this.modulesTableAdapter.Fill(this.resourceAllocationDataSet14.Modules);
            // TODO: This line of code loads data into the 'resourceAllocationDataSet13.Batches' table. You can move, or remove it, as needed.
            this.batchesTableAdapter.Fill(this.resourceAllocationDataSet13.Batches);

        }
    }
}
