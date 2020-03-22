namespace addCrunch
{
    partial class Form1
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
            this.btnBrowseInput = new System.Windows.Forms.Button();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.txtPathToInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathToExtracted = new System.Windows.Forms.TextBox();
            this.btnBrowseExtracted = new System.Windows.Forms.Button();
            this.dlgSelectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnExtract = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPathToExtractedInput = new System.Windows.Forms.TextBox();
            this.btnBrowseExtractedInput = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPathToOutput = new System.Windows.Forms.TextBox();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.btnAssemble = new System.Windows.Forms.Button();
            this.txtFramerate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCheckFrameRate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.btnCheckDuration = new System.Windows.Forms.Button();
            this.btnShowEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Location = new System.Drawing.Point(433, 98);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(29, 24);
            this.btnBrowseInput.TabIndex = 0;
            this.btnBrowseInput.Text = "...";
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            this.btnBrowseInput.Click += new System.EventHandler(this.btnBrowseInput_Click);
            // 
            // txtPathToInput
            // 
            this.txtPathToInput.Location = new System.Drawing.Point(12, 101);
            this.txtPathToInput.Name = "txtPathToInput";
            this.txtPathToInput.Size = new System.Drawing.Size(415, 20);
            this.txtPathToInput.TabIndex = 1;
            this.txtPathToInput.Text = "C:\\Temp\\addCrunch\\testVideo\\MVI_3731.MP4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sökväg till input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Katalog för extracted";
            // 
            // txtPathToExtracted
            // 
            this.txtPathToExtracted.Location = new System.Drawing.Point(12, 30);
            this.txtPathToExtracted.Name = "txtPathToExtracted";
            this.txtPathToExtracted.Size = new System.Drawing.Size(415, 20);
            this.txtPathToExtracted.TabIndex = 4;
            this.txtPathToExtracted.Text = "c:\\temp\\addCrunch\\extracted";
            // 
            // btnBrowseExtracted
            // 
            this.btnBrowseExtracted.Location = new System.Drawing.Point(433, 27);
            this.btnBrowseExtracted.Name = "btnBrowseExtracted";
            this.btnBrowseExtracted.Size = new System.Drawing.Size(29, 24);
            this.btnBrowseExtracted.TabIndex = 3;
            this.btnBrowseExtracted.Text = "...";
            this.btnBrowseExtracted.UseVisualStyleBackColor = true;
            this.btnBrowseExtracted.Click += new System.EventHandler(this.btnBrowseExtracted_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(12, 127);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 6;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Katalog för input";
            // 
            // txtPathToExtractedInput
            // 
            this.txtPathToExtractedInput.Location = new System.Drawing.Point(12, 232);
            this.txtPathToExtractedInput.Name = "txtPathToExtractedInput";
            this.txtPathToExtractedInput.Size = new System.Drawing.Size(415, 20);
            this.txtPathToExtractedInput.TabIndex = 8;
            this.txtPathToExtractedInput.Text = "c:\\temp\\addCrunch\\extracted\\MVI_3731";
            // 
            // btnBrowseExtractedInput
            // 
            this.btnBrowseExtractedInput.Location = new System.Drawing.Point(433, 229);
            this.btnBrowseExtractedInput.Name = "btnBrowseExtractedInput";
            this.btnBrowseExtractedInput.Size = new System.Drawing.Size(29, 24);
            this.btnBrowseExtractedInput.TabIndex = 7;
            this.btnBrowseExtractedInput.Text = "...";
            this.btnBrowseExtractedInput.UseVisualStyleBackColor = true;
            this.btnBrowseExtractedInput.Click += new System.EventHandler(this.btnBrowseExtractedInput_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sökväg till output";
            // 
            // txtPathToOutput
            // 
            this.txtPathToOutput.Location = new System.Drawing.Point(12, 283);
            this.txtPathToOutput.Name = "txtPathToOutput";
            this.txtPathToOutput.Size = new System.Drawing.Size(415, 20);
            this.txtPathToOutput.TabIndex = 11;
            this.txtPathToOutput.Text = "C:\\Temp\\addCrunch\\assembled\\MVI_3731.MP4";
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new System.Drawing.Point(433, 280);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(29, 24);
            this.btnBrowseOutput.TabIndex = 10;
            this.btnBrowseOutput.Text = "...";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // btnAssemble
            // 
            this.btnAssemble.Location = new System.Drawing.Point(12, 309);
            this.btnAssemble.Name = "btnAssemble";
            this.btnAssemble.Size = new System.Drawing.Size(75, 23);
            this.btnAssemble.TabIndex = 13;
            this.btnAssemble.Text = "Assemble";
            this.btnAssemble.UseVisualStyleBackColor = true;
            this.btnAssemble.Click += new System.EventHandler(this.btnAssemble_Click);
            // 
            // txtFramerate
            // 
            this.txtFramerate.Location = new System.Drawing.Point(12, 179);
            this.txtFramerate.Name = "txtFramerate";
            this.txtFramerate.Size = new System.Drawing.Size(100, 20);
            this.txtFramerate.TabIndex = 14;
            this.txtFramerate.Text = "30000/1001";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Bildhastighet";
            // 
            // btnCheckFrameRate
            // 
            this.btnCheckFrameRate.Location = new System.Drawing.Point(113, 127);
            this.btnCheckFrameRate.Name = "btnCheckFrameRate";
            this.btnCheckFrameRate.Size = new System.Drawing.Size(120, 23);
            this.btnCheckFrameRate.TabIndex = 16;
            this.btnCheckFrameRate.Text = "Hämta bildhastighet";
            this.btnCheckFrameRate.UseVisualStyleBackColor = true;
            this.btnCheckFrameRate.Click += new System.EventHandler(this.btnCheckFrameRate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Längd";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(118, 179);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(100, 20);
            this.txtDuration.TabIndex = 17;
            this.txtDuration.Text = "19.052367";
            // 
            // btnCheckDuration
            // 
            this.btnCheckDuration.Location = new System.Drawing.Point(239, 127);
            this.btnCheckDuration.Name = "btnCheckDuration";
            this.btnCheckDuration.Size = new System.Drawing.Size(111, 23);
            this.btnCheckDuration.TabIndex = 19;
            this.btnCheckDuration.Text = "Hämta längd";
            this.btnCheckDuration.UseVisualStyleBackColor = true;
            this.btnCheckDuration.Click += new System.EventHandler(this.btnCheckDuration_Click);
            // 
            // btnShowEdit
            // 
            this.btnShowEdit.Location = new System.Drawing.Point(12, 362);
            this.btnShowEdit.Name = "btnShowEdit";
            this.btnShowEdit.Size = new System.Drawing.Size(105, 23);
            this.btnShowEdit.TabIndex = 20;
            this.btnShowEdit.Text = "Show edit view";
            this.btnShowEdit.UseVisualStyleBackColor = true;
            this.btnShowEdit.Click += new System.EventHandler(this.btnShowEditView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 417);
            this.Controls.Add(this.btnShowEdit);
            this.Controls.Add(this.btnCheckDuration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.btnCheckFrameRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFramerate);
            this.Controls.Add(this.btnAssemble);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPathToOutput);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPathToExtractedInput);
            this.Controls.Add(this.btnBrowseExtractedInput);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPathToExtracted);
            this.Controls.Add(this.btnBrowseExtracted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPathToInput);
            this.Controls.Add(this.btnBrowseInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseInput;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.TextBox txtPathToInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathToExtracted;
        private System.Windows.Forms.Button btnBrowseExtracted;
        private System.Windows.Forms.FolderBrowserDialog dlgSelectFolder;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPathToExtractedInput;
        private System.Windows.Forms.Button btnBrowseExtractedInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPathToOutput;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.Button btnAssemble;
        private System.Windows.Forms.TextBox txtFramerate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCheckFrameRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Button btnCheckDuration;
        private System.Windows.Forms.Button btnShowEdit;
    }
}

