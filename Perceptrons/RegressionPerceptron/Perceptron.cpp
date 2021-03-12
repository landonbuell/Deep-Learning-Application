#include "Perceptron.h"
#include "MathUtils.h"
#include <string>
#include <vector>


Perceptron::Perceptron(std::string name, const int nodesInput, const int nodesOutput ) 
	: _nodesInput(nodesInput) , _nodesOutput(nodesOutput)
{
	// Constructor for base perceptron class
	_name = name;
	_type = "BasePerceptronClass";

	_shapeWeights0 = new int[] {1, _nodesOutput};
	_shapeWeights1 = new int[] {_nodesInput, _nodesOutput};
	
	
	
}

Perceptron::~Perceptron()
{
	// Destructor for Perceptron class
	delete[] _shapeWeights0;
	delete[] _shapeWeights1;

	for (int i = 0; i < _nodesInput; i++)
		delete[] _weights1[i];
	delete[] _weights1;
	delete[] _weights0;

	delete[] _inputs;
	delete[] _outputs;
}

void Perceptron::Fit(int** X, int** Y, int nSamples, int nEpochs)
{
	// Fit Perceptron with Samples X, targets Y, w/ nSamples & nEpochs

	delete[] _costHistory;
	_costHistory = new float[nEpochs];

	for (int i = 0; i < nEpochs; i++)
	{
		// Each training epoch
	}

}

void Perceptron::Predict(int** X, int nSamples)
{
	// Run predictions using weights
}

void Perceptron::Call(int** &X, int nSamples)
{
	// Execute Forward Pass on Perceptron
	int* shapeX = new int[] {nSamples, _nodesInput};
	float** WxTransp = MathUtils::MatrixProduct(X,_weights1,shapeX,_shapeWeights1);
}

