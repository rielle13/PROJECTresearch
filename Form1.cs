using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*bool accountExpand = false;
        private void accTrans_Tick(object sender, EventArgs e)
        {
            if (accountExpand == false)
            {
                accContainer.Height += 10;
                if (accContainer.Height >= 131)
                {
                    accTrans.Stop();
                    accountExpand = true;
                }
            }
            else
            {
                accContainer.Height -= 10;
                if (accContainer.Height <= 74)
                {
                    accTrans.Stop();
                    accountExpand = false;
                }
            }
        }

        private void accSet_Click(object sender, EventArgs e)
        {
            accTrans.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool accountExpand = false;
        private void accTrans_Tick(object sender, EventArgs e)
        {
            if (accountExpand == false)
            {
                accFlow.Height += 10;
                if (accFlow.Height >= 150)
                {
                    accTrans.Stop();
                    accountExpand = true;
                }
            }
            else
            {
                accFlow.Height -= 10;
                if (accFlow.Height <= 57)
                {
                    accTrans.Stop();
                    accountExpand = false;
                }
            }
        }

        private void accSet_Click(object sender, EventArgs e)
        {
            accTrans.Start();
        }*/
    }
}
