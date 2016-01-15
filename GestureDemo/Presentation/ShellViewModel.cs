using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GestureDemo.Presentation
{
    public class ShellViewModel : NotifyPropertyChanged
    {
        private ObservableCollection<MenuItem> menuItems = new ObservableCollection<MenuItem>();
        private MenuItem selectedMenuItem;
        private bool isSplitViewPaneOpen;

        public ShellViewModel()
        {
            this.ToggleSplitViewPaneCommand = new Command(() => this.IsSplitViewPaneOpen = !this.IsSplitViewPaneOpen);
        }

        public ICommand ToggleSplitViewPaneCommand { get; private set; }

        public bool IsSplitViewPaneOpen
        {
            get { return this.isSplitViewPaneOpen; }
            set { Set(ref this.isSplitViewPaneOpen, value); }
        }

        public MenuItem SelectedMenuItem
        {
            get { return this.selectedMenuItem; }
            set
            {
                if (Set(ref this.selectedMenuItem, value)) {
                    OnPropertyChanged("SelectedPageType");

                    // This will handle most cases where the SplitView pane needs to close.
                    // There are other special cases where we may need to manually close the SplitView Pane.
                    // For example, selecting the same menu item will not set this property—therefore, we need
                    // to manually close the Pane in that case.
                    this.IsSplitViewPaneOpen = false;
                }
            }
        }

        public Type SelectedPageType
        {
            get
            {
                if (this.selectedMenuItem != null) {
                    return this.selectedMenuItem.PageType;
                }
                return null;
            }
            set
            {
                // select associated menu item
                this.SelectedMenuItem = this.menuItems.FirstOrDefault(m => m.PageType == value);
            }
        }

        public ObservableCollection<MenuItem> MenuItems
        {
            get { return this.menuItems; }
        }
    }
}
