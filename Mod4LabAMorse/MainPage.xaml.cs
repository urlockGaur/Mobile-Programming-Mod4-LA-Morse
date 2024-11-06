namespace Mod4LabAMorse
{
    public partial class MainPage : ContentPage
    {
        string morseCode1 = "";
        string morseCode2 = "";
        string message1 = "";
        string message2 = "";
        bool isKeyboard1Active = true;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnDotClicked1(object sender, EventArgs e)
        {
            morseCode1 += ".";
            Keyboard1Code.Text = "Keyboard 1 Code: " + morseCode1;
        }

        private void OnDashClicked1(object sender, EventArgs e)
        {
            morseCode1 += "-";
            Keyboard1Code.Text = "Keyboard 1 Code: " + morseCode1;
        }

        private void OnSpaceClicked1(object sender, EventArgs e)
        {
            message1 += Morse.MorseCoder(morseCode1);
            TheText.Text = message1;  
            morseCode1 = "";
            Keyboard1Code.Text = "Keyboard 1 Code: ";
        }

        private void OnDotClicked2(object sender, EventArgs e)
        {
            morseCode2 += ".";
            Keyboard2Code.Text = "Keyboard 2 Code: " + morseCode2;
        }

        private void OnDashClicked2(object sender, EventArgs e)
        {
            morseCode2 += "-";
            Keyboard2Code.Text = "Keyboard 2 Code: " + morseCode2;
        }

        private void OnSpaceClicked2(object sender, EventArgs e)
        {
            message2 += Morse.MorseCoder(morseCode2);
            TheText.Text = message2;  
            morseCode2 = "";
            Keyboard2Code.Text = "Keyboard 2 Code: ";
        }

        private void OnToggleKeyboard(object sender, ToggledEventArgs e)
        {
            isKeyboard1Active = !e.Value;  // True if switch is off (Keyboard 1), false if on (Keyboard 2)

            // Toggle visibility for keyboards and labels 
            Keyboard1.IsVisible = isKeyboard1Active;
            Keyboard1Label.IsVisible = isKeyboard1Active;
            Keyboard1Code.IsVisible = isKeyboard1Active;

            Keyboard2.IsVisible = !isKeyboard1Active;
            Keyboard2Label.IsVisible = !isKeyboard1Active;
            Keyboard2Code.IsVisible = !isKeyboard1Active;

            // Update the toggle label to show the active keyboard
            ToggleLabel.Text = isKeyboard1Active ? "Keyboard 1" : "Keyboard 2";

            // Update the display to show the active keyboard's message
            TheText.Text = isKeyboard1Active ? message1 : message2;
        }

    }
}
