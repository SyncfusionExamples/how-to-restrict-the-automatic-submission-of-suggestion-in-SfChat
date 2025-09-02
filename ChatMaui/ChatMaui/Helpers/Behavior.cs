using Microsoft.Maui.Controls;
using Syncfusion.Maui.Chat;

namespace ChatMaui
{
    public class SfChatSuggestionItemSelectedBehavior : Behavior<SfChat>
    {
        protected override void OnAttachedTo(SfChat bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.SuggestionItemSelected += OnSuggestionItemSelected;
        }

        protected override void OnDetachingFrom(SfChat bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.SuggestionItemSelected -= OnSuggestionItemSelected;
        }

        private void OnSuggestionItemSelected(object? sender, SuggestionItemSelectedEventArgs e)
        {
            e.CancelSendMessage = true;
        }
    }
}