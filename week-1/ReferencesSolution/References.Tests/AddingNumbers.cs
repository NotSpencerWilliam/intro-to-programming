namespace References.Tests
{
    public class AddingNumbers
    {
        [Fact]
        public void CanAddTwoNumbers()
        {
            int a = 10;
            int b = 20;
            int answer;

            answer = a + b;

            Assert.Equal(31, answer);
        }
    }
}
