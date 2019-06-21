﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MessageBoxService.cs" company="FA">
//   Fernando Andreu
// </copyright>
// <summary>
//   Defines the MessageBoxService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OfficeRibbonXEditor.Services
{
    using System.Windows;
    using OfficeRibbonXEditor.Interfaces;

    public class MessageBoxService : IMessageBoxService
    {
        public MessageBoxResult Show(string text, string caption, MessageBoxButton button = MessageBoxButton.OK, MessageBoxImage image = MessageBoxImage.None)
        {
            return MessageBox.Show(text, caption, button, image);
        }
    }
}
