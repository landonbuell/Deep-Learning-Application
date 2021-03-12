#pragma once

#include <iostream>
#include <string>
#include <vector>


class Perceptron
{

public:
	Perceptron(std::string name, const int nodesInput, const int nodesOutput);

	~Perceptron();

	void Fit(int** X, int** Y, int nSamples, int nEpochs);

	void Predict(int** X, int nSamples);

protected:

	// Proteced Feilds
	std::string _name;
	std::string _type;

	const int _nodesInput;
	const int _nodesOutput;

	int* _shapeWeights0;
	int* _shapeWeights1;

	float* _weights0;
	float** _weights1;

	float* _inputs;
	float* _outputs;

	int _currentBatchSize;
	bool _isInitialized;

	float* _costHistory;
	float _currentCost;

	// Protected Methods

	void Call(int** &X, int nSamples);

	void BackPropagate();

	void InititializeWeights();
	
};

