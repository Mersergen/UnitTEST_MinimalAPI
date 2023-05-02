using Calculator;

namespace TestCalculator
{
    public class UnitTest1
    {
        public static IEnumerable<object[]> list = new List<object[]>
        {
            new object[]{2,3,5},
            new object[]{4,7,11},
            new object[]{6,6,12},
            new object[]{2,2,4},
            new object[]{8,1,9},
            new object[]{7,2,9},
            new object[]{ 5,7,12}
        };
        [Theory]
        //[InlineData(2, 3, 5)]
        //[InlineData(12, 30, 42)]
        //[InlineData(52, 15, 67)]
        [MemberData(nameof(list),DisableDiscoveryEnumeration =false)]
        public void TestSum_Input_a_b_Output_c(int a, int b, int c)
        {
            Mathematics m = new Mathematics();
            int result = m.Sum(a, b);
            //Assert.Matches(c.ToString(), result.ToString());
            Assert.Equal(c, result);
        }

        //[Fact]
        //public void TestSum_Input_2_3_Output_5()
        //{
        //    //AAA
        //    //Arange
        //    Mathematics m = new Mathematics();
        //    //Act
        //    int result = m.Sum(2, 3);
        //    //Assert
        //    //Assert.Equal(5, result);
        //    //Assert.True(result==50);
        //    Assert.Matches("5", result.ToString());
        //}
        [Fact]
        public void TestSubstrack_Input_5_2_Output_3()
        {
            Mathematics m = new Mathematics();
            int result = m.Subtract(5, 2);
            Assert.Equal(3, result);
        }
        [Fact]
        public void TestDivide_Input_5_2_Output_2_5()
        {
            Mathematics m = new Mathematics();
            double result = m.Divide(5, 2);
            //Assert.Equal(2.50, result);
            Assert.Matches("2.5", result.ToString());
        }
        [Fact]
        public void TestMod_Input_5_2_Output_1()
        {
            Mathematics m = new Mathematics();
            double result = m.Mod(5, 2);
            Assert.True(1 == result);
        }
        [Fact]
        public void TestFactorial_Input_5_Output_120()
        {
            Mathematics m = new Mathematics();
            double result = m.Factorial(5);
            Assert.True(120 == result);
        }
        [Fact]
        public void TestFibo_Input_10_Output_55()
        {
            Mathematics m = new Mathematics();
            int result = m.Fibonacci_Get_N_Element(10);
            Assert.True(55 == result);
        }
        [Fact]
        public void TestSUM2_Input_3_5_Output_8()
        {
            Mathematics m = new Mathematics();
            int result;
            m.SUM2(3, 5, out result);
            Assert.Equal(8, result);
        }
    }
}