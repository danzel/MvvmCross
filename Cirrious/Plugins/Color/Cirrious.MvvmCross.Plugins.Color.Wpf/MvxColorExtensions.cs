// MvxColorExtensions.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

namespace Cirrious.MvvmCross.Plugins.Color.Wpf
{
    public static class MvxColorExtensions
    {
        public static System.Windows.Media.Color ToNativeColor(this MvxColor color)
        {
            return MvxWpfColor.ToNativeColor(color);
        }
    }
}