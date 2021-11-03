using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class ReshapeMatrix
    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            //check that the count of both are equal
            if (mat.Length * mat[0].Length != r * c) return mat;

            //create new matrix 
            int[][] matrix = new int[r][];
            //add rows
            for (int x = 0; x < r; x++)
            {
                matrix[x] = new int[c];
            }

            //temp array with all values
            int[] array = new int[r * c];
            int count = 0;
            for (int a = 0; a < mat.Length; a++)
            {
                for (int b = 0; b < mat[a].Length; b++)
                {
                    array[count] = mat[a][b];
                    count++;
                }
            }

            //Traverese mat row by row and add elements to matrix in order            
            count = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j <c; j++)
                {
                    matrix[i][j] = array[count];
                    count++;
                }
            }


            return matrix;
        }
    }
}
