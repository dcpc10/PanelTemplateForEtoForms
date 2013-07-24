﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Eto.Drawing;
using Eto.Forms;

namespace PanelTemplate
{
    abstract class ControlPackage : Control, IControlPackage
    {
        public ControlPackage()
            : base(Eto.Generator.Current, typeof(CellAndSlider))
        {
            
        }
        
    }
}