using System.Windows;
using System.Windows.Controls;

namespace SlidScrollBox
{
    public class SlideScrollBox : ListBox
    {
        static SlideScrollBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (SlideScrollBox), new FrameworkPropertyMetadata (typeof (SlideScrollBox)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new SlideScrollBoxItem ();
        }
    }
}
