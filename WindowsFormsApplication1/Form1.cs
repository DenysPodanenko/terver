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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuildGistogramClick(object sender, EventArgs e)
        {
            GistogramForm gf = new GistogramForm();
            gf.Show();
        }

        private void btnCalculateAccuracyClick(object sender, EventArgs e)
        {
            AcuuracyAndAnomalyForm aaaf = new AcuuracyAndAnomalyForm();
            aaaf.Show();
        }

        private void btnCalculateProbablyClick(object sender, EventArgs e)
        {
            ProbabilityValuesForm pvf = new ProbabilityValuesForm();
            pvf.Show();
        }

        private void btnDeleteAnomalyClick(object sender, EventArgs e)
        {

        }
    }
}
