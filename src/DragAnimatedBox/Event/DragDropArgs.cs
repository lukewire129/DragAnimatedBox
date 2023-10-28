namespace DragAnimatedBox.Event
{
    public class DragDropArgs<T1, T2>
    {
        public T1 TargetItem { get; set; }
        public T2 DropItem { get; set; }
    }
}
