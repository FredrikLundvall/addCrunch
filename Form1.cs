using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addCrunch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog(this) == DialogResult.OK)
            {
                txtPathToInput.Text = dlgOpenFile.FileName;
                //VideoFileApi.ExtractFrames(openVideoFileDlg.FileName, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "extracted\\" + Path.GetFileNameWithoutExtension(openVideoFileDlg.FileName)));
                //VideoFileApi.ExtractSound(openVideoFileDlg.FileName, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "extracted\\" + Path.GetFileNameWithoutExtension(openVideoFileDlg.FileName)));
                //VideoFileApi.CombineDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "extracted\\" + Path.GetFileNameWithoutExtension(openVideoFileDlg.FileName)), Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "extracted\\" + Path.GetFileName(openVideoFileDlg.FileName)));
            }
        }

        private void btnBrowseExtracted_Click(object sender, EventArgs e)
        {
            if (dlgSelectFolder.ShowDialog(this) == DialogResult.OK)
            {
                txtPathToExtracted.Text = dlgSelectFolder.SelectedPath;
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            VideoFileApi.ExtractFrames(txtPathToInput.Text, Path.Combine(txtPathToExtracted.Text + "\\",  Path.GetFileNameWithoutExtension(txtPathToInput.Text)));
            VideoFileApi.ExtractSound(txtPathToInput.Text, Path.Combine(txtPathToExtracted.Text + "\\" , Path.GetFileNameWithoutExtension(txtPathToInput.Text)));
            txtFramerate.Text = VideoFileApi.ExtractFramerate(txtPathToInput.Text);
        }

        private void btnBrowseExtractedInput_Click(object sender, EventArgs e)
        {
            if (dlgSelectFolder.ShowDialog(this) == DialogResult.OK)
            {
                txtPathToExtractedInput.Text = dlgSelectFolder.SelectedPath;
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog(this) == DialogResult.OK)
            {
                txtPathToOutput.Text = dlgOpenFile.FileName;
            }
        }

        private void btnAssemble_Click(object sender, EventArgs e)
        {
            VideoFileApi.CombineDirectoryUsingFramerate(txtPathToExtractedInput.Text, txtPathToOutput.Text, txtFramerate.Text);
            //VideoFileApi.CombineDirectoryUsingLength(txtPathToExtractedInput.Text, txtPathToOutput.Text, txtDuration.Text);
            //VideoFileApi.CombineDirectoryUsingLengthAndStartAndNumerOfFrames(txtPathToExtractedInput.Text, txtPathToOutput.Text, txtDuration.Text, 1, 571);
        }

        private void btnCheckFrameRate_Click(object sender, EventArgs e)
        {
            txtFramerate.Text = VideoFileApi.ExtractFramerate(txtPathToInput.Text);
        }

        private void btnCheckDuration_Click(object sender, EventArgs e)
        {
            txtDuration.Text = VideoFileApi.ExtractDuration(txtPathToInput.Text);
        }

        private void btnShowEditView_Click(object sender, EventArgs e)
        {
            EditView editView = new EditView(new ImageRoll(txtPathToExtractedInput.Text));
            editView.Show();
        }
    }
}
