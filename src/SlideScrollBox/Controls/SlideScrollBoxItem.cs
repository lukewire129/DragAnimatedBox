using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SlidScrollBox
{
    public class SlideScrollBoxItem : ContentControl
    {
        public ICommand DragOverCheckCommand
        {
            get { return (ICommand)GetValue (DragOverCheckCommandProperty); }
            set { SetValue (DragOverCheckCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DragOverCheckCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DragOverCheckCommandProperty =
            DependencyProperty.Register ("DragOverCheckCommand", typeof (ICommand), typeof (SlideScrollBoxItem), new PropertyMetadata (null));

        static SlideScrollBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (SlideScrollBoxItem), new FrameworkPropertyMetadata (typeof (SlideScrollBoxItem)));
        }

        public SlideScrollBoxItem()
        {
        }
    }
}
