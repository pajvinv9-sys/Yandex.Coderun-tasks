using System;
using System.Collections.Generic;

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

public class Matrix
{
    public readonly int height;
    public readonly int width;

    private List<List<int>> rows;
    public Matrix(int height, int width, params string[] rows)
    {
        if (rows.Length != height) throw new Exception("Недостаток/избыток строк");
        this.rows = [];

        foreach (var row in rows)
        {
            var r = row.ConvertFromStringToListOfInt();
            if (r.Count != width) throw new Exception("Недостаток/избыток чисел в строке");
            this.rows.Add(r);
        }
        this.height = height;
        this.width = width;
    }

    public int this[int h, int w]
    {
        get { return rows[h][w]; }
        set { rows[h][w] = value; }
    }
}