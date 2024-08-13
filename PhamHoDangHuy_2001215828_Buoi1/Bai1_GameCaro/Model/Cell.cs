﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_GameCaro.Model
{
   public class Cell
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public string Value { get; set; }
        public Cell(int row, int column)
        {
            Row = row;
            Column = column;
            Value = null;
        }
    }
}
