﻿using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = Microsoft.Maui.Graphics.Color;

namespace DSoft.Maui.Controls.ColorPicker
{
	internal class ColorPick
	{

		public ColorPick(string hex)
		{
			Color = Color.FromArgb(hex);
		}

		public ColorPick(Color color)
		{
			Color = color;
		}

		public Color Color { get; set; }
		public int Radius { get; set; }
		public SKPoint Position { get; set; }

		public bool IsTouched(SKPoint pt)
		{

			return (Math.Pow(pt.X - Position.X, 2) / Math.Pow(Radius, 2) +
					Math.Pow(pt.Y - Position.Y, 2) / Math.Pow(Radius, 2)) < 1;
		}

		public bool IsWhite
		{
			get
			{
				return Color.Equals(Colors.White);
			}
		}
	}
}
