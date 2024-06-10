using Syncfusion.Maui.Chat;
using Syncfusion.Maui.DataSource.Extensions;
using Syncfusion.Maui.Popup;
using System.Reflection;

namespace ChatMaui
{
public partial class MainPage : ContentPage
{
        object selectedItem;
    public MainPage()
    {
        InitializeComponent();
    }

        private void sfChat_SendMessage(object sender, SendMessageEventArgs e)
        {
            if (selectedItem  != null) 
            {
                e.Handled = true;
                selectedItem = null;
            }
        }

        private void sfChat_SuggestionItemSelected(object sender, SuggestionItemSelectedEventArgs e)
        {
            selectedItem = e.SelectedItem;
        }
    }

    
}
