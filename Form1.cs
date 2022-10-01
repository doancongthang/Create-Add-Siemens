using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Create_Add_Siemens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateArrayAddSiemens();
        }

        public void CreateArrayAddSiemens()
        {
            for (int i = 0; i < 128; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.WriteLine("I" + i + "." + j); 
                    Console.WriteLine("I" + i + "." + j);
                }
            }
        }
    }
}
