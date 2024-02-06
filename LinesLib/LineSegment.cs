﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesLib
{
    public class LineSegment
    {
        public int Start { get; set; }
        public int End { get; set; }


        public LineSegment(int start, int end)
        {
            Start = start;
            End = end;
        }

        public override string ToString()
        {
            return $"{Start}.. {End}";
        }


    }
}
