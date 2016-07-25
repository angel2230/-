using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 天魔墨香登入器
{
    public partial class Form2 : Form
    {
        int resolution_num = 0;
        
        public Form2(Form1 form1)
        {
            InitializeComponent();
            if(resolution_num==800)
            {
               
                form1.resolution_back.Image = Properties.Resources.re_1024;
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void resolution_800_Click(object sender, EventArgs e)
        {

            resolution_num = 800;
            
        }
        
        
    }
}
