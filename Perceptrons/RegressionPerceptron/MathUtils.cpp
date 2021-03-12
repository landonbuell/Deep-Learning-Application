#include "MathUtils.h"
#include <cassert>

float** MathUtils::ConstructArray2D(int& nRows, int& nCols, float val)
{
	// Construct 2D array of Singles, return ptr
	float** arrPtr2D = new float* [nRows];
	for (int i = 0; i < nRows; i++)
		arrPtr2D[i] = new float[nCols];
	for (int i = 0; i < nRows; i++)
	{
		for (int j = 0; j < nCols; j++)
		{
			arrPtr2D[i][j] = val;
		}
	}
	return arrPtr2D;
}

void MathUtils::GetRow(float**& matArr2D, float*& rowArr1D, int rowIndex, int nCols)
{
	// Get row "rowIndex" from 2D array, put into 1D array
	for (int i = 0; i < nCols; i++)
	{
		rowArr1D[i] = matArr2D[rowIndex][i];
	}
	// rowArr1D now has row 'rowIndex' from matArr2D
}

void MathUtils::GetCol(float**& matArr2D, float*& colArr1D, int colIndex, int nRows)
{
	// Get col "rowIndex" from 2D array, put into 1D array
	for (int i = 0; i < nRows; i++)
	{
		colArr1D[i] = matArr2D[i][colIndex];
	}
	// colArr1D now has row 'colIndex' from matArr2D
}

float MathUtils::ScalarProduct(float*& A, float*& B, int nVals)
{
	// Compute Dot product of A & B
	float scalarProduct = 0;
	for (int i = 0; i < nVals; i++)
	{
		scalarProduct += (A[i] * B[i]);
	}
	return scalarProduct;
}

float** MathUtils::MatrixProduct(float**& A, float**& B, int* shapeA, int* shapeB)
{
	// Compute Matrix Product of A and B
	assert(shapeA[1] == shapeB[0]);
	int nRows = shapeA[0], nCols = shapeB[1];
	int nVals = shapeA[1];
	float** C = ConstructArray2D(nRows, nCols, 0.0f);

	float* rowOfA = new float[nRows];
	float* colOfB = new float[nCols];

	for (int i = 0; i < nRows; i++)
	{
		for (int j = 0; j < nCols; j++)
		{
			GetRow(A, rowOfA, i, nCols);
			GetCol(B, colOfB, j, nRows);
			C[i][j] = ScalarProduct(rowOfA, colOfB, nVals);
		}
	}
	// Delete pointers, return the matrix product
	delete[] rowOfA;
	delete[] colOfB;
	return C;
}