using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_JianZhiOffer
{
    class PrintMatrix
    {
        /// <summary>
        /// 注意各个变量的边界条件
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public List<int> printMatrix(int[][] matrix)
        {
            // write code here
            List<int> rslt = new List<int>();
            int row = matrix.Length - 1;
            int col = matrix[0].Length - 1;
            int r = 0;
            int c = 0;
            while (r <= row && c <= col)
            {
                for (int i = c; i <= col; i++)
                {
                    rslt.Add(matrix[r][i]);
                }
                for (int i = r + 1; i <= row; i++)
                {
                    rslt.Add(matrix[i][col]);
                }
                if (r != row)
                {
                    for (int i = col - 1; i >= c; i--)
                        rslt.Add(matrix[row][i]);
                }
                if (c != col)
                {
                    for (int i = row - 1; i > r; i--)
                        rslt.Add(matrix[i][c]);
                }
                r++;
                c++;
                col--;
                row--;
            }
            return rslt;
        }
    }
}
