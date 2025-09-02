# how-to-restrict-the-automatic-submission-of-suggestion-in-SfChat
This repository contains a sample demonstrating how to restrict the automatic submission of suggestion in .NET MAUI Chat SfChat.

## Sample

```xaml 

        <sfchat:SfChat x:Name="sfChat"
                       Messages="{Binding Messages}"
                       CurrentUser="{Binding CurrentUser}">
            <sfchat:SfChat.Behaviors>
                <local:SfChatSuggestionItemSelectedBehavior />
            </sfchat:SfChat.Behaviors>
        </sfchat:SfChat>

Behavior:

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

```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion® has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion® liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion®'s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion®'s samples.
