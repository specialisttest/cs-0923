﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class TvSet
    {
        public void TvOn(object sender, EventArgs e)
        {
            Console.WriteLine("Телевизор заработал");
        }
    }
}
