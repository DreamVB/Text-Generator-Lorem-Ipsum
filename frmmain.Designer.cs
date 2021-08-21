namespace Lorem_Ipsum
{
    partial class frmmain
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
            this.gWords = new System.Windows.Forms.GroupBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.NumericUpDown();
            this.txtMax = new System.Windows.Forms.NumericUpDown();
            this.lblMax = new System.Windows.Forms.Label();
            this.gParagraphs = new System.Windows.Forms.GroupBox();
            this.txtParCount = new System.Windows.Forms.NumericUpDown();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtRndomText = new System.Windows.Forms.RichTextBox();
            this.chkPar = new System.Windows.Forms.CheckBox();
            this.cmdGen = new System.Windows.Forms.Button();
            this.lblLine3d = new System.Windows.Forms.Label();
            this.cmdCpyClipboard = new System.Windows.Forms.Button();
            this.cmdAbout = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.chkStart = new System.Windows.Forms.CheckBox();
            this.gWords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMax)).BeginInit();
            this.gParagraphs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParCount)).BeginInit();
            this.SuspendLayout();
            // 
            // gWords
            // 
            this.gWords.Controls.Add(this.txtMax);
            this.gWords.Controls.Add(this.lblMax);
            this.gWords.Controls.Add(this.txtMin);
            this.gWords.Controls.Add(this.lblMin);
            this.gWords.Location = new System.Drawing.Point(12, 12);
            this.gWords.Name = "gWords";
            this.gWords.Size = new System.Drawing.Size(240, 75);
            this.gWords.TabIndex = 0;
            this.gWords.TabStop = false;
            this.gWords.Text = "Number of words";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(16, 35);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(24, 13);
            this.lblMin.TabIndex = 0;
            this.lblMin.Text = "Min";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(48, 32);
            this.txtMin.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(63, 20);
            this.txtMin.TabIndex = 1;
            this.txtMin.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(154, 32);
            this.txtMax.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.txtMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(63, 20);
            this.txtMax.TabIndex = 3;
            this.txtMax.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(123, 35);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(27, 13);
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "Max";
            // 
            // gParagraphs
            // 
            this.gParagraphs.Controls.Add(this.txtParCount);
            this.gParagraphs.Controls.Add(this.lblValue);
            this.gParagraphs.Location = new System.Drawing.Point(12, 93);
            this.gParagraphs.Name = "gParagraphs";
            this.gParagraphs.Size = new System.Drawing.Size(240, 75);
            this.gParagraphs.TabIndex = 1;
            this.gParagraphs.TabStop = false;
            this.gParagraphs.Text = "Paragraphs";
            // 
            // txtParCount
            // 
            this.txtParCount.Location = new System.Drawing.Point(57, 32);
            this.txtParCount.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.txtParCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtParCount.Name = "txtParCount";
            this.txtParCount.Size = new System.Drawing.Size(63, 20);
            this.txtParCount.TabIndex = 1;
            this.txtParCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(16, 35);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(37, 13);
            this.lblValue.TabIndex = 0;
            this.lblValue.Text = "Value:";
            // 
            // txtRndomText
            // 
            this.txtRndomText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRndomText.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRndomText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRndomText.Location = new System.Drawing.Point(258, 18);
            this.txtRndomText.Name = "txtRndomText";
            this.txtRndomText.Size = new System.Drawing.Size(361, 294);
            this.txtRndomText.TabIndex = 2;
            this.txtRndomText.Text = "";
            // 
            // chkPar
            // 
            this.chkPar.AutoSize = true;
            this.chkPar.Location = new System.Drawing.Point(12, 175);
            this.chkPar.Name = "chkPar";
            this.chkPar.Size = new System.Drawing.Size(163, 17);
            this.chkPar.TabIndex = 3;
            this.chkPar.Text = "Include HTML paragraph tag";
            this.chkPar.UseVisualStyleBackColor = true;
            this.chkPar.CheckedChanged += new System.EventHandler(this.chkPar_CheckedChanged);
            // 
            // cmdGen
            // 
            this.cmdGen.Location = new System.Drawing.Point(12, 247);
            this.cmdGen.Name = "cmdGen";
            this.cmdGen.Size = new System.Drawing.Size(113, 27);
            this.cmdGen.TabIndex = 4;
            this.cmdGen.Text = "Generate Text";
            this.cmdGen.UseVisualStyleBackColor = true;
            this.cmdGen.Click += new System.EventHandler(this.cmdGen_Click);
            // 
            // lblLine3d
            // 
            this.lblLine3d.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine3d.Location = new System.Drawing.Point(10, 230);
            this.lblLine3d.Name = "lblLine3d";
            this.lblLine3d.Size = new System.Drawing.Size(237, 2);
            this.lblLine3d.TabIndex = 5;
            // 
            // cmdCpyClipboard
            // 
            this.cmdCpyClipboard.Location = new System.Drawing.Point(129, 247);
            this.cmdCpyClipboard.Name = "cmdCpyClipboard";
            this.cmdCpyClipboard.Size = new System.Drawing.Size(113, 27);
            this.cmdCpyClipboard.TabIndex = 6;
            this.cmdCpyClipboard.Text = "Copy to clipbpard";
            this.cmdCpyClipboard.UseVisualStyleBackColor = true;
            this.cmdCpyClipboard.Click += new System.EventHandler(this.cmdCpyClipboard_Click);
            // 
            // cmdAbout
            // 
            this.cmdAbout.Location = new System.Drawing.Point(12, 280);
            this.cmdAbout.Name = "cmdAbout";
            this.cmdAbout.Size = new System.Drawing.Size(113, 27);
            this.cmdAbout.TabIndex = 7;
            this.cmdAbout.Text = "About";
            this.cmdAbout.UseVisualStyleBackColor = true;
            this.cmdAbout.Click += new System.EventHandler(this.cmdAbout_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(129, 280);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(113, 27);
            this.cmdClose.TabIndex = 8;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // chkStart
            // 
            this.chkStart.AutoSize = true;
            this.chkStart.Checked = true;
            this.chkStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStart.Location = new System.Drawing.Point(12, 198);
            this.chkStart.Name = "chkStart";
            this.chkStart.Size = new System.Drawing.Size(140, 17);
            this.chkStart.TabIndex = 9;
            this.chkStart.Text = "Start with \'Lorem Ipsum\' ";
            this.chkStart.UseVisualStyleBackColor = true;
            this.chkStart.CheckedChanged += new System.EventHandler(this.chkStart_CheckedChanged);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 318);
            this.Controls.Add(this.chkStart);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdAbout);
            this.Controls.Add(this.cmdCpyClipboard);
            this.Controls.Add(this.lblLine3d);
            this.Controls.Add(this.cmdGen);
            this.Controls.Add(this.chkPar);
            this.Controls.Add(this.txtRndomText);
            this.Controls.Add(this.gParagraphs);
            this.Controls.Add(this.gWords);
            this.Name = "frmmain";
            this.Text = "Lorem Ipsum Text Generator";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.gWords.ResumeLayout(false);
            this.gWords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMax)).EndInit();
            this.gParagraphs.ResumeLayout(false);
            this.gParagraphs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gWords;
        private System.Windows.Forms.NumericUpDown txtMax;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.NumericUpDown txtMin;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.GroupBox gParagraphs;
        private System.Windows.Forms.NumericUpDown txtParCount;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.RichTextBox txtRndomText;
        private System.Windows.Forms.CheckBox chkPar;
        private System.Windows.Forms.Button cmdGen;
        private System.Windows.Forms.Label lblLine3d;
        private System.Windows.Forms.Button cmdCpyClipboard;
        private System.Windows.Forms.Button cmdAbout;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.CheckBox chkStart;
    }
}

