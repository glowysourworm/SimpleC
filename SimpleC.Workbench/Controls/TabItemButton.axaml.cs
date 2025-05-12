using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Media;

namespace SimpleC.Workbench.Controls
{
    public partial class TabItemButton : UserControl
    {
        public TabItemButton()
        {
            InitializeComponent();
        }

        protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
        {
            base.OnPropertyChanged(change);

            // TODO: Have to figure out how Avalonia did their RelativeSource Binding Syntax
            if (change.Property.Name == "Width")
            {
                this.TheEllipse.Width = (double)change.NewValue;
            }
            else if (change.Property.Name == "Height")
            {
                this.TheEllipse.Height = (double)change.NewValue;
            }
        }

        protected override void OnPointerEntered(PointerEventArgs e)
        {
            base.OnPointerEntered(e);

            this.TheEllipse.Fill = Brushes.Red;
        }

        protected override void OnPointerExited(PointerEventArgs e)
        {
            base.OnPointerExited(e);

            this.TheEllipse.Fill = Brushes.LightGray;
        }
    }
}