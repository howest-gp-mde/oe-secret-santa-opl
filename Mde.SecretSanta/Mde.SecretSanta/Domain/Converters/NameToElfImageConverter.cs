using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Mde.SecretSanta.Domain.Converters
{
    public class NameToElfImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string fullname = ((string)value).ToLower();

            char firstLetter = fullname[0];

            char firstBlock = 'h';
            char secondBlock = 'p';
            char thirdBlock = 'w';

            if (firstLetter < firstBlock)
            {
                return ImageSource.FromFile("elf1.png");
            }
            
            if (firstLetter < secondBlock) {
                return ImageSource.FromFile("elf2.png");
            }

            if (firstLetter < thirdBlock)
            {
                return ImageSource.FromFile("elf3.png");
            }

            return ImageSource.FromFile("elf4.png");

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
