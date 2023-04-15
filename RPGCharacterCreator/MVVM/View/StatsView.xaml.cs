using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RPGCharacterCreator.MVVM.View
{
    /// <summary>
    /// Interaction logic for StatsView.xaml
    /// </summary>
    public partial class StatsView : UserControl
    {
        public StatsView()
        {
            InitializeComponent();
        }

        private void strLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            this.statName.Text = "STRENGTH";
            this.statDesc.Text = "The measure of how strong your character is.";
        }

        private void dexLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            this.statName.Text = "DEXTERITY";
            this.statDesc.Text = "The measure of how strong your character is.";
        }

        private void intLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            this.statName.Text = "INTELLIGENCE";
            this.statDesc.Text = "The measure of how strong your character is.";
        }

        private void wisLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            this.statName.Text = "WISDOM";
            this.statDesc.Text = "The measure of how strong your character is.";
        }

        private void conLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            this.statName.Text = "CONSTITUTION";
            this.statDesc.Text = "The measure of how strong your character is.";
        }

        private void chaLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            this.statName.Text = "CHARISMA";
            this.statDesc.Text = "The measure of how strong your character is.";
        }

        private void lckLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            this.statName.Text = "LUCK";
            this.statDesc.Text = "The measure of how strong your character is.";
        }
    }
}
