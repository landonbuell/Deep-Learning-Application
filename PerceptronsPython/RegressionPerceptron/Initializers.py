"""
Landon Buell
Perceptron Classes
Deep Learning App
24 Dec 2020
"""

            #### IMPORTS ####

import numpy as np
import os
import sys

            #### INITIALIZER CLASS DEFINITIONS ####

class Initializer :
    """
    Parent Initializer
    """

    def __init__(self,shape,):
        """ Constructor for Initializer Class """
        self._shape = shape

    def Call (self):
        """ Initialize Array """
        return np.empty(shape=self._shape)


class UniformInitializer (Initializer):
    """
    Uniform Initializer 
    """

    def __init__(self,shape,value):
        """ Constructor for UniformInitializer Class """
        super().__init__(shape)
        self._value = value

    def Call (self):
        """ Initialize Array with Unifrom Values """
        return np.ones(shape=self._shape) * self._value



            #### OBJECTIVE CLASS DEFINITIONS ####

class Objective :
    """ 
    Parent Objective Function 
    """

