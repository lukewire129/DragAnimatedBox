using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SlideScrollBox.Example.Model;
using System.Collections.ObjectModel;

namespace SlideScrollBox.Example.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty] ObservableCollection<ItemModel> testData;

        public MainViewModel()
        {
            this.TestData = new ();
            TestData.Add (new ItemModel("Item1"));
            TestData.Add (new ItemModel("Item2"));
            TestData.Add (new ItemModel("Item3"));
            TestData.Add (new ItemModel("Item4"));
            TestData.Add (new ItemModel("Item5"));
        }

        [RelayCommand]
        private void Swap(int[] indexes)
        {
            testData.Move (indexes[0], indexes[1]);
        }
    }
}
