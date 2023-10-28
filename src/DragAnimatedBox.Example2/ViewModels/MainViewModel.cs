using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DragAnimatedBox.Event;
using System.Collections.ObjectModel;

namespace DragAnimatedBox.Example.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty] ObservableCollection<string> testData;

        public MainViewModel()
        {
            this.TestData = new ();
            TestData.Add ("Item1");
            TestData.Add ("Item2");
            TestData.Add ("Item3");
            TestData.Add ("Item4");
            TestData.Add ("Item5");
        }

        [RelayCommand]
        private void Swap(DragDropArgs<int, int> obj)
        {
            testData.Move (obj.TargetItem, obj.DropItem);
        }
    }
}
