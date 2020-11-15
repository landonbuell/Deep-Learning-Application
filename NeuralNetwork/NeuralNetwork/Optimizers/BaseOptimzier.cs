﻿using System;
using System.Collections.Generic;
using System.Text;

using NeuralNetwork.ObjectiveFunctions;

namespace NeuralNetwork
{
    namespace Optimizers
    {
        public class BaseOptimizer 
        {
            public string _name;
            

            public BaseOptimizer()
            {
                // Constructor Method for BaseOptimizer Class
                _name = "BaseOptimizer";

            }

            public double LearningRate { get; set; }

            public BaseCostFunction CostFunction { get; set; }
        }
    }
    
}