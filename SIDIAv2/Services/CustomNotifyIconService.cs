﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Wpf.Ui.Common;
using Wpf.Ui.Mvvm.Services;

namespace SIDIAv2.Services;

public class CustomNotifyIconService : NotifyIconService
{
    public CustomNotifyIconService()
    {
        TooltipText = "SIDIAv2 - Service Icon";

        Icon = BitmapFrame.Create(new Uri("pack://application:,,,/Resources/img/logo_mini.png", UriKind.Absolute));

        ContextMenu = new ContextMenu
        {
            FontSize = 14d,
            Items =
            {
                new Wpf.Ui.Controls.MenuItem
                {
                    Header = "Home",
                    SymbolIcon = SymbolRegular.Library28,
                    Tag = "home"
                },
                new Wpf.Ui.Controls.MenuItem
                {
                    Header = "Save",
                    SymbolIcon = SymbolRegular.Save28,
                    Tag = "save"
                },
                new Wpf.Ui.Controls.MenuItem
                {
                    Header = "Open",
                    SymbolIcon = SymbolRegular.Folder28,
                    Tag = "open"
                },
                new Separator(),
                new Wpf.Ui.Controls.MenuItem
                {
                    Header = "Reload",
                    SymbolIcon = SymbolRegular.ArrowClockwise28,
                    Tag = "reload"
                },
            }
        };

        foreach (var singleContextMenuItem in ContextMenu.Items)
            if (singleContextMenuItem is MenuItem)
                ((MenuItem)singleContextMenuItem).Click += OnMenuItemClick;
    }

    protected override void OnLeftClick()
    {
    }

    private void OnMenuItemClick(object sender, RoutedEventArgs e)
    {
        if (sender is not MenuItem menuItem)
            return;

    }
}
