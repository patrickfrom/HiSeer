﻿using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace HiSeer.src.Commands
{
    public class ImageCommand : Command
    {
        public ImageCommand(string commandName, string commandUsage) : base(commandName, commandUsage)
        {
        }

        public override void ExecuteCommand(ListView chatBox)
        {
        }

        public override void ExecuteCommand(ListView chatBox, string parameter)
        {
            Image image = new Image();
            try
            {
                Uri uri = new Uri(parameter);
                image.Source = new BitmapImage(uri);

                image.Width = 100;
                chatBox.Items.Add(image);
            } catch
            {
                Console.WriteLine("Not valid image");
            }
        }
    }
}
