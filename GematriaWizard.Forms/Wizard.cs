#pragma warning disable CS8600, CS8618, CS8605
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GematriaWizard.Dictionary;

namespace GematriaWizard.Forms
{
    public partial class Wizard : Form
    {
        private List<Label> labelControls;
        private Dictionary<string, Label> valueControls;
        private string simpleGematria = "simple";
        private string hebrewGematria = "hebrew";
        private string englishGematria = "english";

        public Wizard()
        {
            InitializeComponent();
            InitializeLabelControls();
            InitializeValueControls();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            this.mainTextBox.TextChanged += mainTextBox_TextChanged;
        }

        private void InitializeLabelControls()
        {
            this.labelControls = new List<Label>()
            {
                this.hebrewGematriaLabel,
                this.hebrewGematriaValueLabel,
                this.englishGematriaLabel,
                this.englishGematriaValueLabel,
                this.simpleGematriaLabel,
                this.simpleGematriaValueLabel
            };
        }

        private void InitializeValueControls()
        {
            this.valueControls = new Dictionary<string, Label>()
            {
                { hebrewGematria, this.hebrewGematriaValueLabel },
                { englishGematria, this.englishGematriaValueLabel },
                { simpleGematria, this.simpleGematriaValueLabel }
            };

            this.ResetValueControls();
        }

        private void ResetValueControls()
        {
            foreach (var label in this.valueControls.Values)
            {
                label.Text = "";
            }
        }

        private void ShowLabelControls()
        {
            foreach (var control in labelControls)
            {
                control.Visible = true;
            }
        }

        private void HideLabelControls()
        {
            foreach (var control in labelControls)
            {
                control.Visible = false;
            }
        }

        #region EventHandlers

        private void mainTextBox_TextChanged(object? sender, EventArgs e)
        {
            var expression = this.mainTextBox.Text;

            if (!string.IsNullOrWhiteSpace(expression))
            {
                this.ShowLabelControls();

                var phrase = Phrase.CreatePhrase(expression);
                this.valueControls[hebrewGematria].Text = phrase.HebrewGematria.ToString();
                this.valueControls[englishGematria].Text = phrase.EnglishGematria.ToString();
                this.valueControls[simpleGematria].Text = phrase.SimpleGematria.ToString();
            }
            else
            {
                this.ResetValueControls();
                this.HideLabelControls();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new AboutForm())
            {
                form.ShowDialog();
            }
        }

        #endregion
    }
}
