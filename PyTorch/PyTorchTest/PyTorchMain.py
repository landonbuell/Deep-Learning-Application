"""
Landon Buell

PyTorch Test
12 March 2020
"""

            #### IMPORTS ####

import numpy as np
import torch
import matplotlib.pyplot as plt

            #### MAIN EXECUTABLE ####

if __name__ == "__main__":

    # Device config
    if torch.cuda.is_available():
        device = torch.device("cuda")
    else:
        device = torch.device("cpu")

    print("=)")
