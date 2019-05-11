using FB;
using Xunit;

namespace FBTest
{
    public class FizzBuzzTest
    {
        [Fact]
        public void show_return_Fizz_when_receive_three()
        {
            Assert.Equal("Fizz", FizzBuzz.solution(3));
        }

        [Fact]
        public void show_return_Fizz_when_receive_five()
        {
            Assert.Equal("Buzz", FizzBuzz.solution(5));
        }

        [Fact]
        public void show_return_FizzBuzz_when_receive_fifteen()
        {
            Assert.Equal("FizzBuzz", FizzBuzz.solution(15));
        }

        [Fact]
        public void show_return_twenty_two_when_receive_twenty_twn()
        {
            Assert.Equal("22", FizzBuzz.solution(22));
        }

        [Fact]
        public void show_return_error_when_receive_two_hundred()
        {
            Assert.Equal("The number is not supported", FizzBuzz.solution(200));
        }

    }
}
