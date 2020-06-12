using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Petal_API;

namespace PROJECT_MAYHEM
{
    public partial class Form2 : Form
    {
        ExploitAPI api = new ExploitAPI();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            api.AddFire();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            api.AddSmoke();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            api.AddSparkles();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            api.CreateForceField();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            api.DoBlockHead();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            api.RemoveLimbs();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            api.RemoveFire();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            api.DoKill();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            api.IsUpdated();
        }
    }
}
