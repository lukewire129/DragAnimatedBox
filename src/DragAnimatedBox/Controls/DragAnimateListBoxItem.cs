using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DragAnimatedBox.Controls
{
    public class DragAnimateListBoxItem : ContentControl
    {
        // Using a DependencyProperty as the backing store for DragOverCheckCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DragOverCheckCommandProperty =
            DependencyProperty.Register ("DragOverCheckCommand", typeof (ICommand), typeof (DragAnimateListBoxItem), new PropertyMetadata (null));

        static DragAnimateListBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (DragAnimateListBoxItem), new FrameworkPropertyMetadata (typeof (DragAnimateListBoxItem)));
        }
    }
}
