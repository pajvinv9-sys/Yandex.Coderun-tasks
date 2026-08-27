using System;
using System.Text;

namespace coderun
{
    public static class TheRouteOfTheMaximumCost
    {
        public static void OutputTheRouteOfTheMaximumCost(this Matrix matrix)
        {
            StringBuilder path = new();
            bool isFirstRow = true;
            for (int h = matrix.height - 1; h >= 0; h--)
            {
                if (isFirstRow) isFirstRow = false;
                else matrix[h, matrix.width - 1] += matrix[h + 1, matrix.width - 1];

                for (int w = matrix.width - 2; w >= 0; w--)
                {
                    var right = matrix[h, w + 1];
                    var bottom = (h == matrix.height - 1) ? int.MinValue : matrix[h + 1, w];

                    if (right > bottom)
                    {
                        matrix[h, w] += right;
                    }
                    else
                    {
                        matrix[h, w] += bottom;
                    }
                }
            }
            Console.WriteLine(matrix[0, 0]);

            int i = matrix.height - 1;
            int j = matrix.width - 1;

            int row = 0, col = 0;
            while (row < matrix.height - 1 || col < matrix.width - 1)
            {
                if (row == matrix.height - 1)
                {
                    col++;
                    path.Append("R ");
                }
                else if (col == matrix.width - 1)
                {
                    row++;
                    path.Append("D ");
                }
                else
                {
                    if (matrix[row, col + 1] > matrix[row + 1, col])
                    {
                        col++;
                        path.Append("R ");
                    }
                    else
                    {
                        row++;
                        path.Append("D ");
                    }
                }
            }
            Console.WriteLine(path.ToString());
        }
    }
}
