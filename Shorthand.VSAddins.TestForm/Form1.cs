using System;
using System.Windows.Forms;
using Shorthand.VSAddins.JsonVisualizer;

namespace Shorthand.VSAddins.TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VisualizerForm form = new VisualizerForm();
            form.Show();
        }
    }
}
