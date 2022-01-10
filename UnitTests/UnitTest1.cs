using Xunit;
using System;
using System.Collections.Generic;
using ClassLibrary1;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var printNum = new Class1(100, "fizz", "buzz",3,5);
            IEnumerable<String> nums = printNum.printNums();
            int i = 1;
            foreach (String num in nums)
            {
                if(i == 15)
                {
                    Assert.Equal("fizzbuzz",num);
                }
                i++;
            }
        }
        [Fact]
        public void Test2()
        {
            var printNum = new Class1(100, "", "", 3, 5);
            IEnumerable<String> nums = printNum.printNums();
            int i = 1;
            foreach (String num in nums)
            {
                if (i == 15)
                {
                    Assert.Equal("fizzbuzz", num);
                }
                i++;
            }
        }
        [Fact]
        public void Test3()
        {
            var printNum = new Class1(100, "beep", "ring", 3, 5);
            IEnumerable<String> nums = printNum.printNums();
            int i = 1;
            foreach (String num in nums)
            {
                if (i == 15)
                {
                    Assert.Equal("beepring", num);
                }
                i++;
            }
        }
        [Fact]
        public void Test4()
        {
            var printNum = new Class1(50, "beep", "ring", 3, 5);
            IEnumerable<String> nums = printNum.printNums();
            int i = 0;
            foreach (String num in nums)
            {
                i++;
            }
            Assert.True(i < 51);
        }
        [Fact]
        public void Test5()
        {
            var printNum = new Class1(100, "fizz", "buzz", 3, 5);
            IEnumerable<String> nums = printNum.printNums();
            int i = 1;
            foreach (String num in nums)
            {
                if (i == 13)
                {
                    Assert.Equal("13", num);
                }
                i++;
            }
        }
        [Fact]
        public void Test6()
        {
            var printNum = new Class1(100, "fizz", "buzz", 3, 5);
            IEnumerable<String> nums = printNum.printNums();
            int i = 1;
            foreach (String num in nums)
            {
                if (i == 13)
                {
                    Assert.Equal("13", num);
                }
                i++;
            }
        }
        [Fact]
        public void Test7()
        {
            var printNum = new Class1(100, "fizz", "buzz", 3, 5);
            IEnumerable<String> nums = printNum.printNums();
            int i = 1;
            foreach (String num in nums)
            {
                if (i == 6)
                {
                    Assert.Equal("fizz", num);
                }
                i++;
            }
        }
        [Fact]
        public void Test8()
        {
            var printNum = new Class1(100, "fizz", "buzz", 3, 5);
            IEnumerable<String> nums = printNum.printNums();
            int i = 1;
            foreach (String num in nums)
            {
                if (i == 10)
                {
                    Assert.Equal("buzz", num);
                }
                i++;
            }
        }
        [Fact]
        public void Test9()
        {
            var printNum = new Class1(100, "hello", "world", 2, 3);
            IEnumerable<String> nums = printNum.printNums();
            int i = 1;
            foreach (String num in nums)
            {
                if (i == 6)
                {
                    Assert.Equal("helloworld", num);
                }
                i++;
            }
        }
        [Fact]
        public void Test10()
        {
            var printNum = new Class1(100, null, null, 2, 3);
            IEnumerable<String> nums = printNum.printNums();
            int i = 1;
            foreach (String num in nums)
            {
                if (i == 6)
                {
                    Assert.Equal("fizzbuzz", num);
                }
                i++;
            }
        }
        [Fact]
        public void Test11()
        {
            var printNum = new Class1(100, null, null, 2, 3);
            IEnumerable<String> nums = printNum.printNums();
            int i = 1;
            foreach (String num in nums)
            {
                if (i == 5)
                {
                    Assert.Equal("5", num);
                }
                i++;
            }
        }
        [Fact]
        public void Test12()
        {
            var printNum = new Class1(100, null, null, 2, 3);
            IEnumerable<String> nums = printNum.printNums();
            int i = 1;
            foreach (String num in nums)
            {
                if (i == 2)
                {
                    Assert.Equal("fizz", num);
                }
                i++;
            }
        }
        [Fact]
        public void Test13()
        {
            var printNum = new Class1(100, null, null, 2, 7);
            IEnumerable<String> nums = printNum.printNums();
            int i = 1;
            foreach (String num in nums)
            {
                if (i == 21)
                {
                    Assert.Equal("buzz", num);
                }
                i++;
            }
        }
        public void Test14()
        {
            var printNum = new Class1(2147483647, null, null, 2, 7);
            IEnumerable<String> nums = printNum.printNums();
            int i = 1;
            foreach (String num in nums)
            {
                if (i == 2147483647)
                {
                    Assert.Equal("2147483647", num);
                }
                i++;
            }
        }
    }
}