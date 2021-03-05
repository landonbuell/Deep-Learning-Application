using System;

namespace Tensor
{
    class TensorMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Make 1D arr of singles
            int nVals = 16;
            float[] testArr = new float[nVals];
            for (int i = 0; i < nVals; i++)
                testArr[i] = Convert.ToSingle(i);

            Tensor myTensor1 = new Tensor(testArr);

            Tensor myTensor2 = new Tensor(12.0f);

            Console.WriteLine("Hello World!");
        }
    }
}
