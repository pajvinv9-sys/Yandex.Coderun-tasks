using System;

namespace coderun;

public static class TheCheapestWay
{
    public static int GetTheCheapestWay(this Matrix matrix)
    {
        bool isFirstRow = true;
        for (int h = matrix.height - 1; h >= 0; h--)
        {
            if (isFirstRow) isFirstRow = false;
            else matrix[h, matrix.width - 1] += matrix[h + 1, matrix.width - 1];

            for (int w = matrix.width - 2; w >= 0; w--)
            {
                var right = matrix[h, w + 1];
                var bottom = (h == matrix.height - 1) ? int.MaxValue : matrix[h + 1, w];
                matrix[h, w] += Math.Min(right, bottom);
            }
        }

        return matrix[0,0];
    }
}