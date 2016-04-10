using System;
using Windows.UI.Xaml.Controls;

namespace GestureDemo.Presentation
{
    public class MenuItem : NotifyPropertyChanged
    {
        private string title;
        private Type pageType;

        public string Title
        {
            get { return this.title; }
            set { Set(ref this.title, value); }
        }

        public Type PageType
        {
            get { return this.pageType; }
            set { Set(ref this.pageType, value); }
        }

        public Symbol IconPage { get; set; }

        public char SymbolAsChar
        {
            get
            {
                return (char)this.IconPage;
            }
        }
    }
}