﻿using System.ComponentModel;

namespace LeoPetri.Common
{
    public enum DateIntervals
    {
        [DefaultValue("Dia")]
        Day = 1,
        [DefaultValue("Mês")]
        Month = 2,
        [DefaultValue("Ano")]
        Year = 3,
        [DefaultValue("Hora")]
        Hour = 4,
        [DefaultValue("Minuto")]
        Minute = 5,
        [DefaultValue("Segundo")]
        Second = 6,
        [DefaultValue("Milisegundo")]
        Millisecond = 7,
        [DefaultValue("Tick")]
        Tick = 8
    }
}
