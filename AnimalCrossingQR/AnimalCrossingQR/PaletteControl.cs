﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalCrossingQR
{
    public partial class PaletteControl : UserControl
    {
        public PaletteList Items { get; private set; }
        public int SelectedItem
        {
            get { return SelectedIndex == -1 ? -1 : Items[SelectedIndex]; }
            set { if (SelectedIndex != -1) Items[SelectedIndex] = value; }
        }

        private int selectedIndex;
        public int SelectedIndex { get { return selectedIndex; } set { selectedIndex = value; Invalidate(); } }

        private Brush[] paletteBrushes;

        public PaletteControl()
        {
            Items = new PaletteList(15, Invalidate);

            paletteBrushes = Palette.ColorPalette
                .Select(c => new SolidBrush(System.Drawing.Color.FromArgb(c.Red, c.Green, c.Blue)))
                .ToArray();

            InitializeComponent();
        }

        private void Palette_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < Items.Length; i++)
            {
                e.Graphics.FillRectangle(i == SelectedIndex ? Brushes.Gold : Brushes.Black, new Rectangle(5 - 2, 5 - 2 + 20 * i, 50 + 4, 15 + 4));
                e.Graphics.FillRectangle(paletteBrushes[Items[i]], new Rectangle(5, 5 + 20 * i, 50, 15));
            }
        }

        private void PaletteControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X > 5 && e.X < 55)
                SelectedIndex = (e.Y - 5) / 20;
        }
    }

    public class PaletteList
    {
        private int[] colors;
        private Action invalidate;

        public int Length { get { return colors.Length; } }

        public PaletteList(int size, Action invalidate = null)
        {
            colors = new int[size];
            this.invalidate = invalidate;
        }

        private void CallInvalidate()
        {
            if (invalidate != null)
                invalidate();
        }

        public int this[int index]
        {
            get { return colors[index]; }
            set { colors[index] = value; CallInvalidate(); }
        }
    }
}