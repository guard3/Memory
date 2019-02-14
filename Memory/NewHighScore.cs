using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class NewHighScore : Form
    {
        string name = "Anonymous";
        public string UserName { get { return name; } }
        public NewHighScore()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "") name = nameTextBox.Text;
            Close();
        }
    }
}
