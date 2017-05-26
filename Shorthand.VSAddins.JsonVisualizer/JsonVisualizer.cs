using Microsoft.VisualStudio.DebuggerVisualizers;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(Shorthand.VSAddins.JsonVisualizer.JsonVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(string),
    Description = "Json Visualizer")]
namespace Shorthand.VSAddins.JsonVisualizer
{
    public class JsonVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            var json = objectProvider.GetObject() as string;

            var form = new VisualizerForm { Json = json };
            windowService.ShowDialog(form);
        }
    }
}
