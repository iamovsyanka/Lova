namespace Models.Current
{
    public class CurrentTest
    {
        private static int id;

        public static void SetTestId(int testId) => id = testId;

        public static int GetTestId() => id;
    }
}
