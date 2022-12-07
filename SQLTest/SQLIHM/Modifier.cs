using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLIHM
{
    public partial class Modifier : Form
    {
        public string ID { set { textBoxID.Text = value; } }
        public string Nom { get { return textBoxNom.Text; } set { textBoxNom.Text = value; } }
        public string Prenom { get { return textBoxPrenom.Text; } set { textBoxPrenom.Text = value; } }
        public string Age { get { return textBoxAge.Text; } set { textBoxAge.Text = value; } }
        public string Sexe { get { return textBoxSexe.Text; } set { textBoxSexe.Text = value; } }
        public Modifier()
        {
            InitializeComponent();
        }



        private void buttonModifier_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }
    }
}
