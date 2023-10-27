using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SlideScrollBox.Controls
{
    public class DragAnimatePanelCore :Panel
    {
        static DragAnimatePanelCore()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (DragAnimatePanelCore), new FrameworkPropertyMetadata (typeof (DragAnimatePanelCore)));
        }
        #region dependency properties		
        public static readonly DependencyProperty ItemsWidthProperty =
          DependencyProperty.Register (
                  "ItemsWidth",
                  typeof (double),
                  typeof (DragAnimatePanelCore),
                  new FrameworkPropertyMetadata (150d));

        public static readonly DependencyProperty ItemsHeightProperty =
          DependencyProperty.Register (
                  "ItemsHeight",
                  typeof (double),
                  typeof (DragAnimatePanelCore),
                  new FrameworkPropertyMetadata (60d));

        public static readonly DependencyProperty ItemSeparationProperty =
         DependencyProperty.Register (
                 "ItemSeparation",
                 typeof (Thickness),
                 typeof (DragAnimatePanelCore),
                 new FrameworkPropertyMetadata ());

        // Using a DependencyProperty as the backing store for AnimationMilliseconds.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AnimationMillisecondsProperty =
            DependencyProperty.Register ("AnimationMilliseconds", typeof (int), typeof (DragAnimatePanelCore), new FrameworkPropertyMetadata (200));

        public static readonly DependencyProperty SwapCommandProperty =
          DependencyProperty.Register (
                  "SwapCommand",
                  typeof (ICommand),
                  typeof (DragAnimatePanelCore),
                  new FrameworkPropertyMetadata (null));

        #endregion

        #region properties
        public double ItemsWidth
        {
            get { return (double)GetValue (ItemsWidthProperty); }
            set { SetValue (ItemsWidthProperty, value); }
        }
        public double ItemsHeight
        {
            get { return (double)GetValue (ItemsHeightProperty); }
            set { SetValue (ItemsHeightProperty, value); }
        }
        public Thickness ItemSeparation
        {
            get { return (Thickness)this.GetValue (ItemSeparationProperty); }
            set { this.SetValue (ItemSeparationProperty, value); }
        }
        protected int AnimationMilliseconds
        {
            get { return (int)GetValue (AnimationMillisecondsProperty); }
            set { SetValue (AnimationMillisecondsProperty, value); }
        }
        protected double itemContainterHeight
        {
            get { return ItemSeparation.Top + ItemsHeight + ItemSeparation.Bottom; }
        }
        protected double itemContainterWidth
        {
            get { return ItemSeparation.Left + ItemsWidth + ItemSeparation.Right; }
        }
        public ICommand SwapCommand
        {
            get { return (ICommand)GetValue (SwapCommandProperty); }
            set { SetValue (SwapCommandProperty, value); }
        }
        #endregion
    }
}
