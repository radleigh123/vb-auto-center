using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VB_Auto_Center
{
    public partial class Form1 : Form
    {
        private string[ , ] prNumbers;

        public Form1()
        {
            InitializeComponent();
            prNumbers = new string[ , ]
            {
                { "PR214", "MR43T", "RBL8", "14K22" },
                { "PR223", "R43", "RJ6", "14K24" },
                { "PR224", "R43N", "RN4", "14K30" },
                { "PR246", "R46N", "RN8", "14K32" },
                { "PR247", "R46TS", "RBL17Y", "14K33" },
                { "PR248", "R46TX", "RBL12-6", "14K35" },
                { "PR324", "S46", "J1l", "14K38" },
                { "PR326", "SR46E", "XEJ8", "14K40" },
                { "PR444", "47L", "H12", "14K44" }
            };

            // pre-defined inputs
            prNumberTBox.Text = "MR43T";
            ARadio.Checked = true;
        }

        private void find_prNumber(string prNumber, char brand)
        {
            for (int i = 0; i < prNumbers.GetLength(0); i++)
            {
                int brIndex = brand == 'A' ? 1 : brand == 'B' ? 2 : 3;

                if (prNumbers[i, brIndex] == prNumber)
                {
                    VBLabel.Text = prNumbers[i, 0];
                    return;
                }
            }

            MessageBox.Show(@"Part number does not exist");
            VBLabel.Text = "";
        }

        private void enterBut_Click(object sender, EventArgs e)
        {
            string prNumber = prNumberTBox.Text;
            char brand = Convert.ToChar(ARadio.Checked ? "A" : BRadio.Checked ? "B" : "X");

            find_prNumber(prNumber, brand);
        }
    }
}
