using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GematriaWizard.Forms
{
    public partial class AboutForm : Form
    {
        private static readonly string AboutText =
@$"Gematria Wizard
   by David Cole
   {Constants.Copyright} 2022
   Version: {Assembly.GetExecutingAssembly().GetName().Version}";

        public AboutForm()
        {
            InitializeComponent();
            aboutLabel.Text = AboutText;
        }
    }
}
