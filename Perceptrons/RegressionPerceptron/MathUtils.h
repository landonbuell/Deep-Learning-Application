#pragma once



static class MathUtils
{
public:
	static float** ConstructArray2D(int&, int&, float);

	static void GetRow(float**&, float*&, int, int);

	static void GetCol(float**&, float*&, int, int);

	static float ScalarProduct(float*&, float*&, int);

	static float** MatrixProduct(float**&, float**&, int*, int*);

};

