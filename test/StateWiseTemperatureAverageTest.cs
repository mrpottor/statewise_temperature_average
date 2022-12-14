namespace test
{
    [TestFixture]
    public class Tests
    {
        [TestCase(new int[] { 9, 8, 2 }, ExpectedResult = 6)]
        [TestCase(new int[] { 9, 8, 4 }, ExpectedResult = 7)]

        public int GetStateWiseAverage_Should_Return_Average(int[] values)
        {
            int[][] temp = new int[1][]
                                    {
                                        values
                                    };
            var result = Program.GetStateWiseAverage(0, temp);
            return result;
        }

        [TestCase(2)]
        [TestCase(3)]
        public void GetStateWiseAverage_Should_Throw_Exception(int index)
        {
            int[][] temp = new int[][]
                                    {
                                        new int[]{ 9, 8, 2 }
                                    };
            Assert.That(() => Program.GetStateWiseAverage(2, temp), Throws.InstanceOf<IndexOutOfRangeException>());
            ;
        }
    }
}