using RPGCharacterCreator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator.MVVM.Model
{
    interface IThemeFactory
    {
        Theme createTheme(string theme);

    }

    class ThemeFactory : IThemeFactory
    {
        public Theme createTheme(string theme)
        {
            if (theme == "dark")
            {
                return new DarkTheme();

            }
            else
                return new LightTheme();
        }
    }

    class Theme : ObservableObject
    {
        private string _backgroundColor;

        public string BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; OnPropertyChanged(); }
        }
        private string _tabColor;

        public string TabColor
        {
            get { return _tabColor; }
            set { _tabColor = value; OnPropertyChanged(); }
        }

        private string _borderColor1;

        public string BorderColor1
        {
            get { return _borderColor1; }
            set { _borderColor1 = value; OnPropertyChanged(); }
        }

        private string _borderColor2;

        public string BorderColor2
        {
            get { return _borderColor2; }
            set { _borderColor2 = value; OnPropertyChanged(); }
        }

        private string _buttonColor;

        public string ButtonColor
        {
            get { return _buttonColor; }
            set { _buttonColor = value; OnPropertyChanged(); }
        }

        private string _textColor;

        public string TextColor
        {
            get { return _textColor; }
            set { _textColor = value; OnPropertyChanged(); }
        }


    }

    class DarkTheme : Theme
    {
        private string _backgroundColor;

        public new string BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; OnPropertyChanged(); }
        }
        private string _tabColor;

        public new string TabColor
        {
            get { return _tabColor; }
            set { _tabColor = value; OnPropertyChanged(); }
        }

        private string _borderColor1 = "#36393E";

        public new string BorderColor1
        {
            get { return _borderColor1; }
            set { _borderColor1 = value; OnPropertyChanged(); }
        }

        private string _borderColor2;

        public new string BorderColor2
        {
            get { return _borderColor2; }
            set { _borderColor2 = value; OnPropertyChanged(); }
        }

        private string _buttonColor;

        public new string ButtonColor
        {
            get { return _buttonColor; }
            set { _buttonColor = value; OnPropertyChanged(); }
        }

        private string _textColor;

        public new string TextColor
        {
            get { return _textColor; }
            set { _textColor = value; OnPropertyChanged(); }
        }

    }

    class LightTheme : Theme
    {
        private string _backgroundColor;

        public new string BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; OnPropertyChanged(); }
        }
        private string _tabColor;

        public new string TabColor
        {
            get { return _tabColor; }
            set { _tabColor = value; OnPropertyChanged(); }
        }

        private string _borderColor1;

        public new string BorderColor1
        {
            get { return _borderColor1; }
            set { _borderColor1 = value; OnPropertyChanged(); }
        }

        private string _borderColor2;

        public new string BorderColor2
        {
            get { return _borderColor2; }
            set { _borderColor2 = value; OnPropertyChanged(); }
        }



        private string _buttonColor;

        public new string ButtonColor
        {
            get { return _buttonColor; }
            set { _buttonColor = value; OnPropertyChanged(); }
        }

        private string _textColor;

        public new string TextColor
        {
            get { return _textColor; }
            set { _textColor = value; OnPropertyChanged(); }
        }
    }
}