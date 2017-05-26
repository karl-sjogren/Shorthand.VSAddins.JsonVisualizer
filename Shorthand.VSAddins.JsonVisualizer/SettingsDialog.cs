using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Shorthand.VSAddins.JsonVisualizer
{
    public partial class SettingsDialog : Form
    {
        private const string SampleJson = @"{""glossary"":{""title"":""example glossary"", ""identifier"": 123456890, ""available"": true, ""GlossDiv"":
{""title"":""S"",""GlossList"":{""GlossEntry"":{""ID"":""SGML"",""SortAs"":null,""GlossTerm"":""Standard Generalized Markup Language"",
""Acronym"": null,""Abbrev"":""ISO 8879:1986"", ""identifier"": 987654321,""GlossDef"":{""para"":""A meta-markup language, used to create markup languages such as DocBook."", ""available"": false,""GlossSeeAlso"":[""GML"",""XML""]},""GlossSee"":""markup""}}}}}";


        public SettingsDialog()
        {
            InitializeComponent();
        }

        private void LoadTemplate()
        {
            Stream docStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Shorthand.VSAddins.JsonVisualizer.Template.html");

            string html = string.Empty;
            if (docStream != null)
                using (var sr = new StreamReader(docStream))
                    html = sr.ReadToEnd();

            string stringColor = null;
            string numberColor = null;
            string booleanColor = null;
            string nullColor = null;
            string keyColor = null;
            string bracesColor = null;
            string bracketsColor = null;
            string backgroundColor = null;

            var key = Registry.CurrentUser.OpenSubKey("Software\\Shorthand Software\\Json Visualizer", false);
            if (key != null)
            {
                stringColor = key.GetValue("stringColor", "green") as string;
                numberColor = key.GetValue("numberColor", "darkorange") as string;
                booleanColor = key.GetValue("booleanColor", "blue") as string;
                nullColor = key.GetValue("nullColor", "magenta") as string;
                keyColor = key.GetValue("keyColor", "red") as string;
                bracesColor = key.GetValue("bracesColor", "black") as string;
                bracketsColor = key.GetValue("bracketsColor", "black") as string;
                backgroundColor = key.GetValue("backgroundColor", "white") as string;
            }

            html = html.Replace("/*stringColor*/", stringColor);
            html = html.Replace("/*numberColor*/", numberColor);
            html = html.Replace("/*booleanColor*/", booleanColor);
            html = html.Replace("/*nullColor*/", nullColor);
            html = html.Replace("/*keyColor*/", keyColor);
            html = html.Replace("/*bracesColor*/", bracesColor);
            html = html.Replace("/*bracketsColor*/", bracketsColor);
            html = html.Replace("/*backgroundColor*/", backgroundColor);

            var json = SampleJson;
            json = json.Replace("\\", "\\\\");
            json = json.Replace("\t", "\\t");
            json = json.Replace("\n", "\\n");
            json = json.Replace("\r", "\\r");

            html = html.Replace("{{JSON_HERE}}", json);
            wbViewer.DocumentText = html;
        }

        private void SettingsDialog_Load(object sender, EventArgs e)
        {
            var key = Registry.CurrentUser.OpenSubKey("Software\\Shorthand Software\\Json Visualizer", false);
            if (key != null)
            {
                txtStringColor.Text = key.GetValue("stringColor", "green") as string;
                txtNumberColor.Text = key.GetValue("numberColor", "darkorange") as string;
                txtBooleanColor.Text = key.GetValue("booleanColor", "blue") as string;
                txtNullColor.Text = key.GetValue("nullColor", "magenta") as string;
                txtKeyColor.Text = key.GetValue("keyColor", "red") as string;
                txtBracesColor.Text = key.GetValue("bracesColor", "black") as string;
                txtBracketsColor.Text = key.GetValue("bracketsColor", "black") as string;
                txtBackgroundColor.Text = key.GetValue("backgroundColor", "white") as string;
            }

            LoadTemplate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var key = Registry.CurrentUser.CreateSubKey("Software\\Shorthand Software\\Json Visualizer");
            if (key != null)
            {
                key.SetValue("stringColor", txtStringColor.Text);
                key.SetValue("numberColor", txtNumberColor.Text);
                key.SetValue("booleanColor", txtBooleanColor.Text);
                key.SetValue("nullColor", txtNullColor.Text);
                key.SetValue("keyColor", txtKeyColor.Text);
                key.SetValue("bracesColor", txtBracesColor.Text);
                key.SetValue("bracketsColor", txtBracketsColor.Text);
                key.SetValue("backgroundColor", txtBackgroundColor.Text);
            }

            LoadTemplate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var key = Registry.CurrentUser.OpenSubKey("Software\\Shorthand Software\\Json Visualizer", true);
            if (key != null)
            {
                key.DeleteValue("stringColor", false);
                key.DeleteValue("numberColor", false);
                key.DeleteValue("booleanColor", false);
                key.DeleteValue("nullColor", false);
                key.DeleteValue("keyColor", false);
                key.DeleteValue("bracesColor", false);
                key.DeleteValue("bracketsColor", false);
                key.DeleteValue("backgroundColor", false);
            }

            SettingsDialog_Load(null, EventArgs.Empty);
            LoadTemplate();
        }

        private void btnBrowseClick(object sender, EventArgs e)
        {
            var type = (sender as Button).Name;
            Color startingColor = Color.Transparent;

            switch (type)
            {
                case "btnBrowseString":
                    startingColor = ColorFromHex(txtStringColor.Text);
                    break;
                case "btnBrowseNumber":
                    startingColor = ColorFromHex(txtNumberColor.Text);
                    break;
                case "btnBrowseBoolean":
                    startingColor = ColorFromHex(txtBooleanColor.Text);
                    break;
                case "btnBrowseNull":
                    startingColor = ColorFromHex(txtNullColor.Text);
                    break;
                case "btnBrowseKey":
                    startingColor = ColorFromHex(txtKeyColor.Text);
                    break;
                case "btnBrowseBraces":
                    startingColor = ColorFromHex(txtBracesColor.Text);
                    break;
                case "btnBrowseBrackets":
                    startingColor = ColorFromHex(txtBracketsColor.Text);
                    break;
                case "btnBrowseBackground":
                    startingColor = ColorFromHex(txtBackgroundColor.Text);
                    break;
                default:
                    MessageBox.Show(this, "Something went wrong, please check for dragons.", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }

            if (startingColor != Color.Transparent)
                colorDialog1.Color = startingColor;

            if (colorDialog1.ShowDialog(this) != DialogResult.OK)
                return;

            switch (type)
            {
                case "btnBrowseString":
                    txtStringColor.Text = ColorToHex(colorDialog1.Color);
                    break;
                case "btnBrowseNumber":
                    txtNumberColor.Text = ColorToHex(colorDialog1.Color);
                    break;
                case "btnBrowseBoolean":
                    txtBooleanColor.Text = ColorToHex(colorDialog1.Color);
                    break;
                case "btnBrowseNull":
                    txtNullColor.Text = ColorToHex(colorDialog1.Color);
                    break;
                case "btnBrowseKey":
                    txtKeyColor.Text = ColorToHex(colorDialog1.Color);
                    break;
                case "btnBrowseBraces":
                    txtBracesColor.Text = ColorToHex(colorDialog1.Color);
                    break;
                case "btnBrowseBrackets":
                    txtBracketsColor.Text = ColorToHex(colorDialog1.Color);
                    break;
                case "btnBrowseBackground":
                    txtBackgroundColor.Text = ColorToHex(colorDialog1.Color);
                    break;
                default:
                    MessageBox.Show(this, "Something went wrong, please check for dragons.", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private static string ColorToHex(Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        private static Color ColorFromHex(string input)
        {
            try
            {
                return ColorTranslator.FromHtml(input);
            }
            catch (Exception)
            {
                return Color.Transparent;
            }
        }

        
    }
}
