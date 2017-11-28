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
    public partial class GistogramForm : Form
    {
        public GistogramForm()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void btnOpenClick(object sender, EventArgs e)
        {
            ofd.Filter = "txt| *.txt";
            string path="";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblPath.Text = ofd.SafeFileName;
                path = ofd.FileName;
            }

            Sample sample = new Sample(path);
            sample.setPockets();
            Dictionary<string, int> a = sample.getValueOfPockets();


            foreach(KeyValuePair<string, int> dict in sample.getValueOfPockets())
            {
                this.sampleGistogram.Series["pocket"].Points.AddXY(dict.Key,dict.Value);
            }
        }
    }
}
