﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Lamp
    {

        public void LightOn(object sender, EventArgs e)
        {
            Console.WriteLine("Лампа зажглась");
        }
    }
}
