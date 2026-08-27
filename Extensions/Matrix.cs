using System;
using System.Collections.Generic;
namespace coderun;
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