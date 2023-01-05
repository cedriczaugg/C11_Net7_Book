﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared;

internal interface IPlayabke
{
    void Play();
    void Pause();

    void Stop() // default interface implementation.
    {
        WriteLine("Default implementation of Stop");
    }

}
