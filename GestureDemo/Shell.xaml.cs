using GestureDemo.Pages;
using GestureDemo.Presentation;
using System.Linq;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;

namespace GestureDemo
{
    public sealed partial class Shell : UserControl
    {
        public Shell()
        {
            this.InitializeComponent();

            var vm = new ShellViewModel();
            vm.MenuItems.Add(new MenuItem { IconPage = Symbol.Emoji2, Title = "Welcome", PageType = typeof(WelcomePage) });
            vm.MenuItems.Add(new MenuItem { IconPage = Symbol.Setting, Title = "Page 1", PageType = typeof(Page1) });
            vm.MenuItems.Add(new MenuItem { IconPage = Symbol.Street, Title = "Page 2", PageType = typeof(Page2) });
            vm.MenuItems.Add(new MenuItem { IconPage = Symbol.World, Title = "Page 3", PageType = typeof(Page3) });

            // select the first menu item
            vm.SelectedMenuItem = vm.MenuItems.First();

            this.ViewModel = vm;

            // add entry animations
            var transitions = new TransitionCollection { };
            var transition = new NavigationThemeTransition { };
            transitions.Add(transition);
            this.Frame.ContentTransitions = transitions;
        }

        public ShellViewModel ViewModel { get; private set; }

        public Frame RootFrame
        {
            get
            {
                return this.Frame;
            }
        }
    }
}