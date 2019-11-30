﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinLab.Colors
{
    public class ColorModel : IComparable<ColorModel>
    {
        public Color Color { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Default sort by name.
        /// </summary>
        /// <param name="other">
        /// </param>
        /// <returns>
        /// </returns>
        public int CompareTo(ColorModel other)
        {
            if (other == null) return 1;
            else return Comparer<string>.Default.Compare(Name, other.Name);
        }
    }
}