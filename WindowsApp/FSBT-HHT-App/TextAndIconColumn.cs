﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSBT.HHT.App.UI
{
    public class TextAndIconColumn : DataGridViewTextBoxColumn
    {
        private Image imageValue;
        private Size imageSize;

        public TextAndIconColumn()
        {
            this.CellTemplate = new TextAndIconCell();
        }

        public override object Clone()
        {
            TextAndIconColumn c = base.Clone() as TextAndIconColumn;
            c.imageValue = this.imageValue;
            c.imageSize = this.imageSize;
            return c;
        }

        public Image Image
        {
            get { return this.imageValue; }
            set
            {
                if (this.Image != value)
                {
                    this.imageValue = value;
                    this.imageSize = value.Size;

                    if (this.InheritedStyle != null)
                    {
                        Padding inheritedPadding = this.InheritedStyle.Padding;
                        this.DefaultCellStyle.Padding = new Padding(imageSize.Width,
                     inheritedPadding.Top, inheritedPadding.Right,
                     inheritedPadding.Bottom);
                    }
                }
            }
        }
        private TextAndIconCell TextAndImageCellTemplate
        {
            get { return this.CellTemplate as TextAndIconCell; }
        }
        internal Size ImageSize
        {
            get { return imageSize; }
        }
    }

    public class TextAndIconCell : DataGridViewTextBoxCell
    {
        private Image imageValue;
        private Size imageSize;

        public override object Clone()
        {
            TextAndIconCell c = base.Clone() as TextAndIconCell;
            c.imageValue = this.imageValue;
            c.imageSize = this.imageSize;
            return c;
        }

        public Image Image
        {
            get
            {
                if (this.OwningColumn == null ||
            this.OwningTextAndImageColumn == null)
                {

                    return imageValue;
                }
                else if (this.imageValue != null)
                {
                    return this.imageValue;
                }
                else
                {
                    return this.OwningTextAndImageColumn.Image;
                }
            }
            set
            {
                if (this.imageValue != value)
                {
                    this.imageValue = value;
                    this.imageSize = value.Size;

                    Padding inheritedPadding = this.InheritedStyle.Padding;
                    this.Style.Padding = new Padding(imageSize.Width,
                    inheritedPadding.Top, inheritedPadding.Right,
                    inheritedPadding.Bottom);
                }
            }
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds,
        Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState,
        object value, object formattedValue, string errorText,
        DataGridViewCellStyle cellStyle,
        DataGridViewAdvancedBorderStyle advancedBorderStyle,
        DataGridViewPaintParts paintParts)
        {
            // Paint the base content
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState,
               value, formattedValue, errorText, cellStyle,
               advancedBorderStyle, paintParts);

            if (this.Image != null)
            {
                // Draw the image clipped to the cell.
                System.Drawing.Drawing2D.GraphicsContainer container =
                graphics.BeginContainer();

                graphics.SetClip(cellBounds);
                graphics.DrawImageUnscaled(this.Image, cellBounds.Location);

                graphics.EndContainer(container);
            }
        }

        private TextAndIconColumn OwningTextAndImageColumn
        {
            get { return this.OwningColumn as TextAndIconColumn; }
        }
    }
}
