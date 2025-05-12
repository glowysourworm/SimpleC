using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Controls.Templates;
using Avalonia.Input;
using Avalonia.Media;

namespace SimpleC.Workbench.ControlTemplates
{
    public class TabItemHeaderTemplate : IDataTemplate
    {
        // !!! BAD. The designer probably had nowhere to go to fix this implementation issue.
        object? _theData = null;

        string _header;
        RadialGradientBrush _normalFill;
        RadialGradientBrush _hoverFill;

        // How to accomplish binding?
        public string Header
        {
            get { return _header; }
            set { _header = value; }
        }

        public TabItemHeaderTemplate()
        {
            _normalFill = new RadialGradientBrush()
            {
                Center = new Avalonia.RelativePoint(0.5D, 0.5D, Avalonia.RelativeUnit.Relative),
                GradientOrigin = new Avalonia.RelativePoint(0.5D, 0.5D, Avalonia.RelativeUnit.Relative),
                GradientStops = new GradientStops()
                {
                    new GradientStop(Colors.Gray, 0),
                    new GradientStop(Colors.Gray, 0.8),
                    new GradientStop(Colors.White, 1)
                }
            };
            _hoverFill = new RadialGradientBrush()
            {
                Center = new Avalonia.RelativePoint(0.5D, 0.5D, Avalonia.RelativeUnit.Relative),
                GradientOrigin = new Avalonia.RelativePoint(0.5D, 0.5D, Avalonia.RelativeUnit.Relative),
                GradientStops = new GradientStops()
                {
                    new GradientStop(Colors.Red, 0),
                    new GradientStop(Colors.Red, 0.8),
                    new GradientStop(Colors.White, 1)
                }
            };
        }

        public bool Match(object? data)
        {
            // Supposing there is one instance of the template per use (!!!) 
            //return _theData == data;

            return true;
        }

        public Control? Build(object? param)
        {
            _theData = param;

            var textBlock = new TextBlock()
            {
                Text = this.Header,
                FontSize = 14,
                FontWeight = FontWeight.Bold,
                VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center
            };
            var ellipseButton = new Ellipse()
            {
                Width = 13,
                Height = 13,
                Margin = new Avalonia.Thickness(5, 1, 1, 1),
                Stroke = Brushes.Gray,
                StrokeThickness = 0.5,
                VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
                Fill = _normalFill
            };
            var panel = new StackPanel()
            {
                Orientation = Avalonia.Layout.Orientation.Horizontal,
                Children = { textBlock, ellipseButton }
            };
            var result = new TabItem()
            {
                Header = panel,
                Cursor = new Cursor(StandardCursorType.Hand),
                Padding = new Avalonia.Thickness(5, 0),
                Background = Brushes.White
            };

            ellipseButton.PointerEntered += EllipseButton_PointerEntered;
            ellipseButton.PointerExited += EllipseButton_PointerExited;

            return result;
        }

        private void EllipseButton_PointerExited(object? sender, PointerEventArgs e)
        {
            var ellipse = sender as Ellipse;

            if (ellipse != null)
            {
                ellipse.Fill = _normalFill;
            }
        }

        private void EllipseButton_PointerEntered(object? sender, PointerEventArgs e)
        {
            var ellipse = sender as Ellipse;

            if (ellipse != null)
            {
                ellipse.Fill = _hoverFill;
            }
        }
    }
}
