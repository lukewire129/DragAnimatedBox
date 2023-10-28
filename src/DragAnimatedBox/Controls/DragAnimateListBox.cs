using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DragAnimatedBox.Controls
{
    public class DragAnimateListBox : ListBox
    {
        public double ChildrenWidth
        {
            get { return (double)GetValue (ChildrenWidthProperty); }
            set { SetValue (ChildrenWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ChildrenWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ChildrenWidthProperty =
            DependencyProperty.Register ("ChildrenWidth", typeof (double), typeof (DragAnimateListBox), new PropertyMetadata (0.0));

        public double ChildrenHeight
        {
            get { return (double)GetValue (ChildrenHeightProperty); }
            set { SetValue (ChildrenHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ChildrenWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ChildrenHeightProperty =
            DependencyProperty.Register ("ChildrenHeight", typeof (double), typeof (DragAnimateListBox), new PropertyMetadata (0.0));

        public Thickness ChildrenSpacing
        {
            get { return (Thickness)GetValue (ChildrenSpacingProperty); }
            set { SetValue (ChildrenSpacingProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ChildrenWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ChildrenSpacingProperty =
            DependencyProperty.Register ("ChildrenSpacing", typeof (Thickness), typeof (DragAnimateListBox), new PropertyMetadata (new Thickness(0)));



        public ICommand SwapCommand
        {
            get { return (ICommand)GetValue (SwapCommandProperty); }
            set { SetValue (SwapCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SwapCommandProperty =
            DependencyProperty.Register ("SwapCommand", typeof (ICommand), typeof (DragAnimateListBox), new PropertyMetadata (null));



        static DragAnimateListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (DragAnimateListBox), new FrameworkPropertyMetadata (typeof (DragAnimateListBox)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new DragAnimateListBoxItem ();
        }
    }
}
