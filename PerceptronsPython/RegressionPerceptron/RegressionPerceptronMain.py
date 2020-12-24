"""
Landon Buell
Main Executable
Deep Learning App
24 Dec 2020
"""

                #### IMPORTS ####

import numpy as np
import os
import sys

import Perceptrons

                #### MAIN EXECUTABLE ####

if __name__ == "__main__":

    # CREATE DUMMY DATA
    W = np.array([1,2,3],dtype=float)
    b = np.array([-1])
    X = np.array([[0,0,0],[1,1,1],[2,2,2],[3,3,3]],dtype=float)
    Y = np.array([-1,5,13,17],dtype=float)


    JARVIS = Perceptrons.RegressionPerceptron("JARVIS",3)
    
    YY = JARVIS.Call(X)

    print(YY)
