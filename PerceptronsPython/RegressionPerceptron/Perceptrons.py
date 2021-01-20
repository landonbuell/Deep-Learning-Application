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

            #### CLASSS DEFINITIONS ####

class Perceptron:
    """ 
    Parent Class for All Perceptrons
    """

    def __init__(self,name,inputNodes):
        """ Constructor for Base Perceptron Class """
        self._name = name
        self._type = "AbstractPerceptron"
        self._inputNodes = inputNodes
        self._outputNodes = None

    def Initialize (self):
        """ Initialize """
     
    def Call (self,X):
        """ Call Perceptron with Inputs X """
        return X
        

class RegressionPerceptron (Perceptron):
    """ 
    Regression Perceptron Class
    """

    def __init__(self,name,inputNodes):
        """ Constructor for RegressionPerceptron Class """
        super().__init__(name,inputNodes)
        self._outputNodes = 1

        self._shapeWeights = np.array([1,self._inputNodes])
        self._shapeBiases = np.array([1])

        self._weights = np.empty(shape=self._shapeWeights)
        self._biases = np.empty(shape=self._shapeBiases)

    def Initialize ():
        pass


    def Call (self, X):
        """ Call Regression perceptron with Inputs X """
        return np.matmul(X, self._weights.transpose()) + self._biases