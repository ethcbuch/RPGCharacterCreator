using RPGCharacterCreator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

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
        private Brush _backgroundColor;

        public Brush BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; OnPropertyChanged(); }
        }
        private Brush _tabColor;

        public Brush TabColor
        {
            get { return _tabColor; }
            set { _tabColor = value; OnPropertyChanged(); }
        }

        private Brush _borderColor1;

        public Brush BorderColor1
        {
            get { return _borderColor1; }
            set { _borderColor1 = value; OnPropertyChanged(); }
        }

        private Brush _borderColor2;

        public Brush BorderColor2
        {
            get { return _borderColor2; }
            set { _borderColor2 = value; OnPropertyChanged(); }
        }

        private Brush _buttonColor;

        public Brush ButtonColor
        {
            get { return _buttonColor; }
            set { _buttonColor = value; OnPropertyChanged(); }
        }

        private Brush _textColor;

        public Brush TextColor
        {
            get { return _textColor; }
            set { _textColor = value; OnPropertyChanged(); }
        }

        private Brush _mouseOver;
        public Brush MouseOver
        {
            get { return _mouseOver; }
            set { _mouseOver = value; OnPropertyChanged(); }
        }
        private Brush _buttonClicked;
        public Brush ButtonClicked
        {
            get { return _buttonClicked; }
            set { _buttonClicked = value; OnPropertyChanged(); }
        }

    }

    class DarkTheme : Theme
    {
        BrushConverter convert;

        public DarkTheme()
        {
            convert = new BrushConverter();

            _backgroundColor = (Brush)convert.ConvertFromString("#424549");
            _tabColor = (Brush)convert.ConvertFromString("#36393E");
            _borderColor1 = (Brush)convert.ConvertFromString("#1E2124");
            _borderColor2 = (Brush)convert.ConvertFromString("#A0A0A0");
            _buttonColor = (Brush)convert.ConvertFromString("#36393E");
            _textColor = (Brush)convert.ConvertFromString("#FFFFFF");
            _buttonClicked = (Brush)convert.ConvertFromString("#282A2D");
            _mouseOver = (Brush)convert.ConvertFromString("#34363A");


        }

        private Brush _backgroundColor { get; set; }
        public new Brush BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; OnPropertyChanged(); }
        }
        private Brush _tabColor;

        public new Brush TabColor
        {
            get { return _tabColor; }
            set { _tabColor = value; OnPropertyChanged(); }
        }

        private Brush _borderColor1;

        public new Brush BorderColor1
        {
            get { return _borderColor1; }
            set { _borderColor1 = value; OnPropertyChanged(); }
        }

        private Brush _borderColor2;

        public new Brush BorderColor2
        {
            get { return _borderColor2; }
            set { _borderColor2 = value; OnPropertyChanged(); }
        }

        private Brush _buttonColor;

        public new Brush ButtonColor
        {
            get { return _buttonColor; }
            set { _buttonColor = value; OnPropertyChanged(); }
        }

        private Brush _textColor;

        public new Brush TextColor
        {
            get { return _textColor; }
            set { _textColor = value; OnPropertyChanged(); }
        }

        private Brush _mouseOver;
        public new Brush MouseOver
        {
            get { return _mouseOver; }
            set { _mouseOver = value; OnPropertyChanged(); }
        }
        private Brush _buttonClicked;
        public new Brush ButtonClicked
        {
            get { return _buttonClicked; }
            set { _buttonClicked = value; OnPropertyChanged(); }
        }
    }

    class LightTheme : Theme
    {
        BrushConverter convert;

        public LightTheme()
        {
            convert = new BrushConverter();

            _backgroundColor = (Brush)convert.ConvertFromString("#D8D8D8");
            _tabColor = (Brush)convert.ConvertFromString("#C9CCCC");
            _borderColor1 = (Brush)convert.ConvertFromString("#565656");
            _borderColor2 = (Brush)convert.ConvertFromString("#999999");
            _buttonColor = (Brush)convert.ConvertFromString("#C9CCCC");
            _textColor = (Brush)convert.ConvertFromString("#2D2D3A");
            _buttonClicked = (Brush)convert.ConvertFromString("#ADADAD");
            _mouseOver = (Brush)convert.ConvertFromString("#ABADAD");

        }

        private Brush _backgroundColor;

        public new Brush BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; OnPropertyChanged(); }
        }
        private Brush _tabColor;

        public new Brush TabColor
        {
            get { return _tabColor; }
            set { _tabColor = value; OnPropertyChanged(); }
        }

        private Brush _borderColor1;

        public new Brush BorderColor1
        {
            get { return _borderColor1; }
            set { _borderColor1 = value; OnPropertyChanged(); }
        }

        private Brush _borderColor2;

        public new Brush BorderColor2
        {
            get { return _borderColor2; }
            set { _borderColor2 = value; OnPropertyChanged(); }
        }



        private Brush _buttonColor;

        public new Brush ButtonColor
        {
            get { return _buttonColor; }
            set { _buttonColor = value; OnPropertyChanged(); }
        }

        private Brush _textColor;

        public new Brush TextColor
        {
            get { return _textColor; }
            set { _textColor = value; OnPropertyChanged(); }
        }

        private Brush _mouseOver;
        public new Brush MouseOver
        {
            get { return _mouseOver; }
            set { _mouseOver = value; OnPropertyChanged(); }
        }

        private Brush _buttonClicked;
        public new Brush ButtonClicked
        {
            get { return _buttonClicked; }
            set { _buttonClicked = value; OnPropertyChanged(); }
        }
    }
}