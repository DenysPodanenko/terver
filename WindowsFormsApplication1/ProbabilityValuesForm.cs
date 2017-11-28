using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ProbabilityValuesForm : Form
    {
        public ProbabilityValuesForm()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void btnOpenClick(object sender, EventArgs e)
        {
            ofd.Filter = "txt| *.txt";
            string path = "";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblPath.Text = ofd.SafeFileName;
                path = ofd.FileName;
            }

            Sample sample = new Sample(path);

            lblMean.Text = sample.sampleMean().ToString();
            lblVariance.Text = sample.sampleVariance().ToString();
            lblStandartDeviation.Text = sample.sampleStandartDeviation().ToString();
            lblAsymetry.Text = sample.sampleAsymetry().ToString();
            lblExces.Text = sample.sampleExces().ToString();
        }
    }
}
