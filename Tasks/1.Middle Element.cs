namespace coderun;
public static class MiddleElement
{
    public static int GetMiddleElement(this string s)
    {
        var l = s.ConvertFromStringToListOfInt();

        if (l[0] > l[1])
        {
            if (l[0] > l[2])
            {
                if (l[1] > l[2])
                    return l[1];

                return l[2];
            }
            return l[0];
        }

        if (l[0] < l[2])
        {
            if (l[1] > l[2])
                return l[2];
            return l[1];
        }

        return l[0];
    }
}