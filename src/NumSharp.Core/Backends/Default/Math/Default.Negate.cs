﻿/*
This file was generated by template ../NDArray.Elementwise.tt
In case you want to do some changes do the following 

1 ) adapt the tt file
2 ) execute powershell file "GenerateCode.ps1" on root level

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Numerics;
using NumSharp.Shared;
using System.Threading.Tasks;

namespace NumSharp.Backends
{
    public abstract partial class DefaultEngine
    {
        public virtual NDArray Negate(NDArray x)
        {
            return x.negate();
        }
    }
}
