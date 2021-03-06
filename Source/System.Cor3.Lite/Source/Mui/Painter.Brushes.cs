﻿/* oio * 8/3/2015 * Time: 6:39 AM
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace Mui
{
	public partial class Painter
	{
    static public Pen GetPen(ColourClass cc, float width)
    {
      return new Pen(DictColour[cc],width);
    }
    static public Brush GetBrush(ColourClass cc)
    {
      return DictBrush[cc];
    }
    static public Pen GetPen(Color cc, float width)
    {
      return new Pen(cc,width);
    }
    static public readonly Dictionary<ColourClass, Color> DictColour = new Dictionary<ColourClass, Color>() {
      { ColourClass.Active, Color.FromArgb(255, 0, 127, 255) },
      { ColourClass.Black, Color.Black },
      { ColourClass.Dark20, Color.FromArgb(255, 20, 20, 20) },
      { ColourClass.Dark30, Color.FromArgb(255, 30, 30, 30) },
      { ColourClass.Dark40, Color.FromArgb(255, 40, 40, 40) },
      { ColourClass.Dark50, Color.FromArgb(255, 50, 50, 50) },
      { ColourClass.Dark70, Color.FromArgb(255, 70, 70, 70) },
      { ColourClass.Dark90, Color.FromArgb(255, 90, 90, 90) },
      { ColourClass.Default, Color.Red },
      { ColourClass.Disabled, Color.Gray },
      { ColourClass.Focus, Color.Orange },
      { ColourClass.White, Color.White },
    };
    static public readonly Dictionary<ColourClass, Brush> DictBrush = new Dictionary<ColourClass, Brush> {
      { ColourClass.Active, new SolidBrush(DictColour[ColourClass.Active]) },
      { ColourClass.Black, new SolidBrush(DictColour[ColourClass.Black]) },
      { ColourClass.Dark20, new SolidBrush(DictColour[ColourClass.Dark20]) },
      { ColourClass.Dark30, new SolidBrush(DictColour[ColourClass.Dark30]) },
      { ColourClass.Dark40, new SolidBrush(DictColour[ColourClass.Dark40]) },
      { ColourClass.Dark50, new SolidBrush(DictColour[ColourClass.Dark50]) },
      { ColourClass.Dark70, new SolidBrush(DictColour[ColourClass.Dark70]) },
      { ColourClass.Dark90, new SolidBrush(DictColour[ColourClass.Dark90]) },
      { ColourClass.Default, new SolidBrush(DictColour[ColourClass.Default]) },
      { ColourClass.Disabled, new SolidBrush(DictColour[ColourClass.Disabled]) },
      { ColourClass.Focus, new SolidBrush(DictColour[ColourClass.Focus]) },
      { ColourClass.White, new SolidBrush(DictColour[ColourClass.White]) },
    };
    static public readonly Dictionary<ColourClass, Pen> DictPen = new Dictionary<ColourClass, Pen> {
      { ColourClass.Active, new Pen(DictBrush[ColourClass.Active], 2) { StartCap = LineCap.Round, EndCap = LineCap.Round } },
      { ColourClass.Black, new Pen(DictBrush[ColourClass.Black], 2) { StartCap = LineCap.Round, EndCap = LineCap.Round } },
      { ColourClass.Dark20, new Pen(DictBrush[ColourClass.Dark20], 2) { StartCap = LineCap.Round, EndCap = LineCap.Round } },
      { ColourClass.Dark30, new Pen(DictBrush[ColourClass.Dark30], 2) { StartCap = LineCap.Round, EndCap = LineCap.Round } },
      { ColourClass.Dark40, new Pen(DictBrush[ColourClass.Dark40], 2) { StartCap = LineCap.Round, EndCap = LineCap.Round } },
      { ColourClass.Dark50, new Pen(DictBrush[ColourClass.Dark50], 2) { StartCap = LineCap.Round, EndCap = LineCap.Round } },
      { ColourClass.Dark70, new Pen(DictBrush[ColourClass.Dark70], 2) { StartCap = LineCap.Round, EndCap = LineCap.Round } },
      { ColourClass.Dark90, new Pen(DictBrush[ColourClass.Dark90], 2) { StartCap = LineCap.Round, EndCap = LineCap.Round } },
      { ColourClass.Default, new Pen(DictBrush[ColourClass.Default], 2) { StartCap = LineCap.Round, EndCap = LineCap.Round } },
      { ColourClass.Disabled, new Pen(DictBrush[ColourClass.Disabled], 2) { StartCap = LineCap.Round, EndCap = LineCap.Round } },
      { ColourClass.Focus, new Pen(DictBrush[ColourClass.Focus], 2) { StartCap = LineCap.Round, EndCap = LineCap.Round } },
      { ColourClass.White, new Pen(DictBrush[ColourClass.White], 2) { StartCap = LineCap.Round, EndCap = LineCap.Round } },
    };
	}
}




