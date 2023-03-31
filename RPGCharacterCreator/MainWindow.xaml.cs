using System.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace RPGCharacterCreator
{


    internal static class Creator
    {
        public static GeneralCharacterBuilder builder = new GeneralCharacterBuilder();

        public static CharacterDirector director = new CharacterDirector(builder);
    }



    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void headerThumb_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            Left = Left + e.HorizontalChange;
            Top = Top + e.VerticalChange;
        }
    }
}
