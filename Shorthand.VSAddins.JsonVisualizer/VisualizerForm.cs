using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Shorthand.VSAddins.JsonVisualizer
{
    public partial class VisualizerForm : Form
    {
        public string Json { get; set; }
#if !DEBUG
        private const string TestJson = @"{""glossary"":{""title"":""example glossary"", ""identifier"": 123456890, ""available"": true, ""GlossDiv"":
{""title"":""S"",""GlossList"":{""GlossEntry"":{""ID"":""SGML"",""SortAs"":""SGML"",""GlossTerm"":""Standard Generalized Markup Language"",
""Acronym"":""SGML"",""Abbrev"":""ISO 8879:1986"", ""identifier"": 987654321,""GlossDef"":{""para"":""A meta-markup language, used to create markup languages such as DocBook."", ""available"": false,""GlossSeeAlso"":[""GML"",""XML""]},""GlossSee"":""markup""}}}}}";

        private const string TestJsonInvalidTabs = @"{""glossary"":{""title"":""example glossary"",""GlossDiv"":
{""title"":""S"",""GlossList"":{""GlossEntry"":{""ID"":""SGML"",""SortAs"":""SGML"",""GlossTerm"":""Standard Generalized Markup Language"",
""Acronym"":""SGML"",""Abbrev"":""ISO 8879:1986"",""GlossDef"":{""para"":""A meta-markup 		language, used to create markup languages such as DocBook."",""GlossSeeAlso"":[""GML"",""XML""]},""GlossSee"":""markup""}}}}}";
#endif
        public VisualizerForm()
        {
            InitializeComponent();
        }

        private void VisualizerForm_Load(object sender, EventArgs e)
        {
            LoadJson();
        }

        private void LoadJson()
        {
#if DEBUG
            Json = TestJson;
#endif

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

            var json = Json;
            json = json.Replace("\\", "\\\\");
            json = json.Replace("\t", "\\t");
            json = json.Replace("\n", "\\n");
            json = json.Replace("\r", "\\r");

            html = html.Replace("{{JSON_HERE}}", json);
            wbViewer.DocumentText = html;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var form = new AboutForm();
            form.ShowDialog(this);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var form = new SettingsDialog();
            form.ShowDialog(this);
            LoadJson();
        }
    }
}
