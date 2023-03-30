using System.Windows.Controls;

namespace RPGCharacterCreator.WVVM.View
{
    /// <summary>
    /// Interaction logic for BioView.xaml
    /// </summary>
    public partial class BioView : UserControl
    {
        public BioView()
        {
            InitializeComponent();
        }

        bool hasBeenClicked = false;

        private void bioTextBox_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            if (!hasBeenClicked) 
            {
                bioTextBox.Text = string.Empty;
                hasBeenClicked = true;
            }

        }
    }
}
