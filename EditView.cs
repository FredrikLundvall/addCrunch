using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addCrunch
{
    public partial class EditView : Form
    {
        protected ImageRoll _imageRoll;
        public EditView(ImageRoll imageRoll)
        {
            InitializeComponent();
            _imageRoll = imageRoll;
        }

        private void EditView_Shown(object sender, EventArgs e)
        {
            _imageRoll.UpdateFrameBoundaries();
            updateForm();
        }

        private void updateForm()
        {
            lblFirstFrameNumber.Text = _imageRoll.GetFirstFrameNumber().ToString();
            lblLastFrameNumber.Text = _imageRoll.GetLastFrameNumber().ToString();
            lblFileName.Text = _imageRoll.GetCurrentFrameFilename();
            scrlCurrentFrame.Minimum = _imageRoll.GetFirstFrameNumber();
            scrlCurrentFrame.Maximum = _imageRoll.GetLastFrameNumber();
            picFrame.ImageLocation = _imageRoll.GetCurrentFrameFilename();
            picFrame.Load();

            numPositionX.Minimum = -picFrame.Width;
            numPositionY.Minimum = -picFrame.Height;
            numPositionX.Maximum = picFrame.Width;
            numPositionY.Maximum = picFrame.Height;
            numSizeX.Maximum = picFrame.Width;
            numSizeY.Maximum = picFrame.Height;

            Bitmap bmp = new Bitmap(picFrame.Image);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                //create a color matrix object  
                ColorMatrix matrix = new ColorMatrix();
                //set the opacity  
                matrix.Matrix33 = 0.5f;
                //create image attributes  
                ImageAttributes attributes = new ImageAttributes();
                //set the color(opacity) of the image  
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                Bitmap bmpEffect = new Bitmap(_imageRoll.GetCurrentFrameFilename());
                g.DrawImage(bmpEffect, new Rectangle((int)numPositionX.Value, (int)numPositionY.Value, (int)numSizeX.Value, (int)numSizeY.Value), 0, 0, bmpEffect.Width, bmpEffect.Height, GraphicsUnit.Pixel, attributes);
            }
            picFrame.Image = bmp;
        }

        private void scrlCurrentFrame_Scroll(object sender, ScrollEventArgs e)
        {
            _imageRoll.SetCurrentFrameNumber(e.NewValue);
            updateForm();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {

        }
    }
}
