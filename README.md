# SwipeableSplitView
Trying to enable edge swiping on the native SplitView control in UWP.

1. This SplitView project was initially created based on Koen's awesome UWP templates. (https://visualstudiogallery.msdn.microsoft.com/b3eb9b90-cc39-4b5c-bf94-497cba6e4f6f)
2. Don't use IsPaneOpen, use IsSwipeablePaneOpen instead.
3. At the moment the swipe only works when DisplayMode is Overlay.
4. Currently only left edge is supported.
5. The code is not fully tested, let me know if you find any bugs.

# Update
1. ListView has been replaced with ListBox for better performance and styling.
2. A new property IsPanSelectorEnabled (well proabably badly named :p) has been added to allow users to select a menu item by panning up/down on the bottom area of the left pane. This is an experimental UX design that I came up with a few months ago and hopefully it could be helpful for users with big phones since they don't need to stretch their fingers to reach the top part of the screen.
