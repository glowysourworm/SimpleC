using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Shapes;
using Avalonia.Controls.Templates;
using Avalonia.Media;

namespace SimpleC.Workbench.ControlTemplates
{
    public class ButtonEllipseTemplate : IControlTemplate
    {
        public TemplateResult<Control>? Build(TemplatedControl param)
        {
            return new TemplateResult<Control>(new Ellipse()
            {
                Width = 14,
                Height = 14,
                Fill = Brushes.Red,
                Stroke = Brushes.Black
            }, param.FindNameScope());
        }
    }
}
