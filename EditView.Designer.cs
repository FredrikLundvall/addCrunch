namespace addCrunch
{
    partial class EditView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstFrameNumber = new System.Windows.Forms.Label();
            this.lblLastFrameNumber = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.scrlCurrentFrame = new System.Windows.Forms.HScrollBar();
            this.picFrame = new System.Windows.Forms.PictureBox();
            this.numPositionX = new System.Windows.Forms.NumericUpDown();
            this.numSizeX = new System.Windows.Forms.NumericUpDown();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.numPositionY = new System.Windows.Forms.NumericUpDown();
            this.numSizeY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPositionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPositionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSizeY)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstFrameNumber
            // 
            this.lblFirstFrameNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFirstFrameNumber.AutoSize = true;
            this.lblFirstFrameNumber.Location = new System.Drawing.Point(6, 445);
            this.lblFirstFrameNumber.Name = "lblFirstFrameNumber";
            this.lblFirstFrameNumber.Size = new System.Drawing.Size(35, 13);
            this.lblFirstFrameNumber.TabIndex = 0;
            this.lblFirstFrameNumber.Text = "label1";
            // 
            // lblLastFrameNumber
            // 
            this.lblLastFrameNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastFrameNumber.AutoSize = true;
            this.lblLastFrameNumber.Location = new System.Drawing.Point(633, 445);
            this.lblLastFrameNumber.Name = "lblLastFrameNumber";
            this.lblLastFrameNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLastFrameNumber.Size = new System.Drawing.Size(35, 13);
            this.lblLastFrameNumber.TabIndex = 1;
            this.lblLastFrameNumber.Text = "label1";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(6, 78);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(35, 13);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "label1";
            // 
            // scrlCurrentFrame
            // 
            this.scrlCurrentFrame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrlCurrentFrame.LargeChange = 4;
            this.scrlCurrentFrame.Location = new System.Drawing.Point(9, 458);
            this.scrlCurrentFrame.Name = "scrlCurrentFrame";
            this.scrlCurrentFrame.Size = new System.Drawing.Size(659, 18);
            this.scrlCurrentFrame.TabIndex = 3;
            this.scrlCurrentFrame.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlCurrentFrame_Scroll);
            // 
            // picFrame
            // 
            this.picFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picFrame.Location = new System.Drawing.Point(9, 94);
            this.picFrame.Name = "picFrame";
            this.picFrame.Size = new System.Drawing.Size(659, 348);
            this.picFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFrame.TabIndex = 4;
            this.picFrame.TabStop = false;
            // 
            // numPositionX
            // 
            this.numPositionX.Location = new System.Drawing.Point(371, 31);
            this.numPositionX.Name = "numPositionX";
            this.numPositionX.Size = new System.Drawing.Size(82, 20);
            this.numPositionX.TabIndex = 5;
            // 
            // numSizeX
            // 
            this.numSizeX.Location = new System.Drawing.Point(494, 31);
            this.numSizeX.Name = "numSizeX";
            this.numSizeX.Size = new System.Drawing.Size(82, 20);
            this.numSizeX.TabIndex = 6;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(228, 28);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(75, 23);
            this.btnAddImage.TabIndex = 7;
            this.btnAddImage.Text = "Add image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // numPositionY
            // 
            this.numPositionY.Location = new System.Drawing.Point(371, 57);
            this.numPositionY.Name = "numPositionY";
            this.numPositionY.Size = new System.Drawing.Size(82, 20);
            this.numPositionY.TabIndex = 8;
            // 
            // numSizeY
            // 
            this.numSizeY.Location = new System.Drawing.Point(494, 57);
            this.numSizeY.Name = "numSizeY";
            this.numSizeY.Size = new System.Drawing.Size(82, 20);
            this.numSizeY.TabIndex = 9;
            // 
            // EditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 485);
            this.Controls.Add(this.numSizeY);
            this.Controls.Add(this.numPositionY);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.numSizeX);
            this.Controls.Add(this.numPositionX);
            this.Controls.Add(this.picFrame);
            this.Controls.Add(this.scrlCurrentFrame);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblLastFrameNumber);
            this.Controls.Add(this.lblFirstFrameNumber);
            this.Name = "EditView";
            this.Text = "EditView";
            this.Shown += new System.EventHandler(this.EditView_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPositionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPositionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSizeY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstFrameNumber;
        private System.Windows.Forms.Label lblLastFrameNumber;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.HScrollBar scrlCurrentFrame;
        private System.Windows.Forms.PictureBox picFrame;
        private System.Windows.Forms.NumericUpDown numPositionX;
        private System.Windows.Forms.NumericUpDown numSizeX;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.NumericUpDown numPositionY;
        private System.Windows.Forms.NumericUpDown numSizeY;
    }
}