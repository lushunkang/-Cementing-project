using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 演示建立表1
{
    public partial class 启动飞溅屏 : Form
    {
        public 启动飞溅屏()
        {
            InitializeComponent();
        }
        int processNumber = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(progressBar1.Value<progressBar1.Maximum)
            {
                progressBar1.Value += processNumber;
                progressBar1.PerformStep();
                if(progressBar1.Value>= progressBar1.Maximum)
                {
                    this.Close();
                }
            }


        }
    }
}
