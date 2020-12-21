﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Layers.Utilities
{
    public abstract class LayerParameters
    {

        public int[] WeightShape { get; private set; }

        public int[] BiasShape { get; private set; }

    }
}
