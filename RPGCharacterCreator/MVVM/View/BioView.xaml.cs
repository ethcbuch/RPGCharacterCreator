using System;
using System.Windows.Controls;

namespace RPGCharacterCreator.MVVM.View
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

        private void bioTextBox_GotFocus_1(object sender, System.Windows.RoutedEventArgs e)
        {
            if (!hasBeenClicked)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }
    }
}
