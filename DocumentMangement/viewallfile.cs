using DocumentMangement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentMangement
{
    public partial class viewallfile : Form
    {
        public viewallfile()
        {
            DbContextclass db = new DbContextclass();
            InitializeComponent();


            var customers = from p in db.document
                            select p;
            dataGridView1.DataSource = customers.ToList();
                
                
              
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DocumentUpload obj1 = new DocumentUpload();

            obj1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CostEstmation obj = new CostEstmation();
            obj.Show();
            this.Hide();
        }

        private void DownloadFile_Click(object sender, EventArgs e)
        {
            DownloadDoc obj = new DownloadDoc();
            obj.Show();
            this.Hide();
        }
    }
}
