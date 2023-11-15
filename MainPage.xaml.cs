namespace GA_Prog2_RTB_Access
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        // This display short message click event should replace the text in the editor
        private void btnDisplayShortMessage_Clicked(object sender, EventArgs e)
        {
            string displayMessage = entDisplayMessage.Text;

            editDisplay.Text = displayMessage;
        }

        // The Append short Message event should append the text ( append )
        private void btnAppendShortMessage_Clicked(object sender, EventArgs e)
        {
            string displayMessage = entDisplayMessage.Text;

            editDisplay.Text += displayMessage;
        }

        // This will append the message from our editor ( for long messages )
        private void btnAppendLongMessage_Clicked(object sender, EventArgs e)
        {
            string longMessageToAppend = editUserLongMessage.Text;

            editDisplay.Text += longMessageToAppend;
        }

        // Clear - Clears all text inputs. Both Editors and the Entry
        private void btnClear_Clicked(object sender, EventArgs e)
        {
            entDisplayMessage.Text = "";
            editDisplay.Text = "";
            editUserLongMessage.Text = "";
        }



    }
}