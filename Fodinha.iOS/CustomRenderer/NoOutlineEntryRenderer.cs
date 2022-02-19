using Fodinha.iOS.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Entry), typeof(NoOutlineEntryRenderer))]
namespace Fodinha.iOS.CustomRenderer
{
    public class NoOutlineEntryRenderer : EntryRenderer
    {
        public NoOutlineEntryRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            this.Control.BorderStyle = UIKit.UITextBorderStyle.None;
        }
    }
}
