#pragma once
#include<string>

namespace Layers 
{
	class Layer
	{
	public:

		Layer(std::string name);

		Layer* GetNextLayer();
		Layer* GetPrevLayer();

		


	protected:
		std::string _layerName;
		std::string _layerType;

		Layer* _nextLayer;
		Layer* _prevLayer;

		int _inputShape[] = {};
		int _outputShape[] = {};



	};
}



