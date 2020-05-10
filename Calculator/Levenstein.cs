namespace Calculator
{
    public static class Levenstein
    {
        public static int LevensteinDynamic(string first, string second)
        {
            int firstLenght = first.Length, secondLenght = second.Length;
            int[,] result = new int[(firstLenght + 1), (secondLenght + 1)];

            for (int i = 0; i <= firstLenght; i++)
            {
                result[i, 0] = i;
            }
            for (int j = 0; j <= secondLenght; j++)
            {
                result[0, j] = j;
            }
            for (int i = 1; i <= firstLenght; i++)
            {
                for (int j = 1; j <= secondLenght; j++)
                {
                    result[i, j] = GetMin(result[i - 1, j] + 1, result[i, j - 1] + 1,
                                   result[i - 1, j - 1] + (first[i - 1] == second[j - 1] ? 0 : 1));
                }
            }
            return result[firstLenght, secondLenght];
        }

        private static int GetMin(int xs, int ys, int zs)
        {
            return
                (xs < ys && xs < zs) ? xs :
                (ys < xs && ys < zs) ? ys : zs;
        }
    }
}
