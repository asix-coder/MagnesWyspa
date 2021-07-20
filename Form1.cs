﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagnesWyspa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String result = "";
            int y = 0;
           
            String[] islands = new String[4];
            islands[0] = "Bermudy";
            islands[1] = "Fiji";
            islands[2] = "Azory";
            islands[3] = "Cozumel";

            int[] index = new int[4];
            index[0] = 1;
            index[1] = 3;
            index[2] = 0;
            index[3] = 2;

            int refNum;
            while (y < 4)
            {
                result += "\nWyspa = ";
                refNum = index[y];
                result += islands[refNum];
                y = y + 1;
            }


            MessageBox.Show(result);
        }
    }
}




   