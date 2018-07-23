﻿using System;
using Xamarin.Forms;

namespace samplecode.CustomPickerFolder
{
    public class CustomPicker : Picker
    {
        public static readonly BindableProperty TextSizeProperty =
            BindableProperty.Create(nameof(TextSize), typeof(Int32), typeof(CustomPicker), 24, BindingMode.TwoWay);

        public Int32 TextSize
        {
            set { SetValue(TextSizeProperty, value); }
            get { return (Int32)GetValue(TextSizeProperty); }
        }

        public static BindableProperty PlaceholderColorProperty =
            BindableProperty.Create(nameof(PlaceholderColor), typeof(string), typeof(CustomPicker), "#CCCCCC", BindingMode.TwoWay);

        public string PlaceholderColor
        {
            get { return (string)GetValue(PlaceholderColorProperty); }
            set { SetValue(PlaceholderColorProperty, value); }
        }
    }
}
