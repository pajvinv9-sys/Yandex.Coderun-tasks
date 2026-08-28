namespace coderun;

public static class ButterJob
{
    public static long GetButterJob(this (int x, int y) c)
    {
        if ((c.x + c.y - 2) % 3 != 0) return 0;
        float a = 0;
        if (c.x > c.y) 
            a = ((float)c.x) / ((float)c.y);
        else a = ((float)c.y) / ((float)c.x);

        if (a > 2 || a < 0.5f) return 0;

        int stringNum = (c.x + c.y - 2) / 3;
        int inStringNum = ((c.x > c.y) ? c.y : c.x) - stringNum - 1;

        return Combinatorics.GetPascalTriangleNumber(stringNum, inStringNum);
    }
}
