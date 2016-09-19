using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuLyAnh
{
    public partial class FormChart : Form
    {
        private int[] data;
        public FormChart(int[] data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void FormChart_Load(object sender, EventArgs e)
        {
            var ser = chart.Series[0];
            for (int i=0;i<256;i++)
            {
                ser.Points.Add(new double[] { data[i],i});
            }
        }
    }
}
