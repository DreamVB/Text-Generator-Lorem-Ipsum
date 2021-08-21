using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoremIpsum;

namespace Lorem_Ipsum
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdCpyClipboard_Click(object sender, EventArgs e)
        {
            if (txtRndomText.TextLength > 0)
            {
                txtRndomText.SelectAll();
                txtRndomText.Focus();
                Clipboard.SetText(txtRndomText.Text, TextDataFormat.Text);
            }
        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        }

        private void cmdGen_Click(object sender, EventArgs e)
        {
            TLoremIpsum rt = new TLoremIpsum();
            StringBuilder sb = new StringBuilder();
            //Set some properties.
            rt.MinWord = (int)txtMin.Value;
            rt.MaxWord = (int)txtMax.Value;
            rt.Paragraphs = (int)txtParCount.Value;
            rt.Append_LoremIpsum = chkStart.Checked;
            rt.IncludeHTMLParagraph = chkPar.Checked;
            //Set the text
            sb = rt.LoremIpsum();
            txtRndomText.Text = sb.ToString().TrimEnd();
        }

        private void chkPar_CheckedChanged(object sender, EventArgs e)
        {
            cmdGen_Click(sender, e);
        }

        private void chkStart_CheckedChanged(object sender, EventArgs e)
        {
            cmdGen_Click(sender, e);
        }

        private void cmdAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Text + "\nVersion 1.0\n\tBy Ben a.k.a DreamVB",
                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
