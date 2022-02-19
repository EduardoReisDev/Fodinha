using Android.Content;
using Fodinha.Droid.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(NoOutlineEntryRenderer))]
namespace Fodinha.Droid.CustomRenderer
{
    public class NoOutlineEntryRenderer : EntryRenderer
    {
        public NoOutlineEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            this.Control.Background = null;
        }
    }
}
