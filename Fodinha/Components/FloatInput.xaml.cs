using Xamarin.Forms;

namespace Fodinha.Components
{
    public partial class FloatInput : ContentView
    {
        public string FloatPlaceholder
        {
            get => FloatLabel.Text;
            set => FloatLabel.Text = value;
        }

        public string FloatText
        {
            get => FloatEntry.Text;
            set => FloatEntry.Text = value;
        }

        public bool IsFilled => !string.IsNullOrEmpty(FloatEntry.Text);

        public Keyboard EntryKeyboard
        {
            get => FloatEntry.Keyboard;
            set => FloatEntry.Keyboard = value;
        }

        public FloatInput()
        {
            InitializeComponent();

            FloatEntry.Focused += FloatInputFocused;
            FloatEntry.Unfocused += FloatInputUnfocused;
        }

        private void FloatInputUnfocused(object sender, FocusEventArgs e)
        {
            if (string.IsNullOrEmpty(FloatEntry.Text))
            {
                FloatLabel.ScaleXTo(1);
                FloatLabel.ScaleYTo(1);
                FloatLabel.TranslateTo(0, 0);
            }
        }

        private void FloatInputFocused(object sender, FocusEventArgs e)
        {
            FloatLabel.ScaleYTo(0.8);
            FloatLabel.ScaleXTo(0.8);
            FloatLabel.TranslateTo(0, - FloatLabel.Height);
        }
    }
}
