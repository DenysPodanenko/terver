using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class AcuuracyAndAnomalyForm : Form
    {
        public AcuuracyAndAnomalyForm()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        Sample originSample;
        Sample modSample;

        private void btnOpenClick(object sender, EventArgs e)
        {
            ofd.Filter = "txt| *.txt";
            string path = "";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblPath.Text = ofd.SafeFileName;
                path = ofd.FileName;
            }

            originSample = new Sample(path);
        
            string originSampleSrt = "";
            foreach (double num in originSample.numbers)
            {
                originSampleSrt = originSampleSrt + num.ToString() + " ";
            }
            lblOriginSample.Text = originSampleSrt;

            modSample = new Sample();

            foreach (double num in originSample.numbers)
            {
                double t = Math.Abs(num - originSample.sampleMean()) / originSample.sampleVariance();
                if (t <= 1.96)
                {
                    modSample.numbers.Add(num);
                }
            }

            string modSampleStr = "";

            foreach (double num in modSample.numbers)
            {
                modSampleStr = modSampleStr + num.ToString() + " ";
            }

            lblModSample.Text = modSampleStr;

            btnSave.Enabled = true;
        }

        private void btnSaveClick(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File| *.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream fs =
                   (System.IO.FileStream)sfd.OpenFile();
                fs.Close();
                StreamWriter sw = new StreamWriter(sfd.FileName);

                foreach (double num in modSample.numbers)
                {
                    sw.WriteLine(num.ToString());
                }

                sw.Close();
            }
        }
    }
}
