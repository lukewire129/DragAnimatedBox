using CommunityToolkit.Mvvm.ComponentModel;

namespace SlideScrollBox.Example.Model
{
    public class ItemModel
    {       
        public string ItemName { get; set; }

        public ItemModel(string itemName)
        {
            this.ItemName = itemName;
        }
    }
}
