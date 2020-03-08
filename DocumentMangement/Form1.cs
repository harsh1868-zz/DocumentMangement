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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = textBox1.Text.ToString();
            user.Password = textBox2.Text.ToString();
            textBox1.Text = user.Name;
            DbContextclass db = new DbContextclass();
            db.users.Add(user);
            db.SaveChanges();
            Global.username = textBox1.Text.ToString();
            viewallfile obj1 = new viewallfile();

            obj1.Show();
            this.Hide();

        }
    }
}
