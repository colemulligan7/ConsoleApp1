// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using ClassLibrary1;

Console.WriteLine("UppserBound:");
string maxNumInput = Console.ReadLine();
int maxNum = 100, firstNum = 0, secondNum = 0;

//Second guessed myself, couldn't remember if naming the divisible number was part of it but it was easy enough so I just did it quick. 
Console.WriteLine("First Evenly Divisible Number:");
string firstDivisible = Console.ReadLine();
if (firstDivisible != null)
{
    Int32.TryParse(firstDivisible, out firstNum);
    if (firstNum <= 0)
    {
        firstNum = 3;
    }
}
Console.WriteLine("Second Evenly Divisible Number:");
string secondDivisible = Console.ReadLine();
if (secondDivisible != null)
{
    Int32.TryParse(secondDivisible, out secondNum);
    if (secondNum <= 0)
    {
        secondNum = 5;
    }
}
Console.WriteLine("What is the word you would like printed when divisible by " + firstNum + "?");
String word1 =  Console.ReadLine();
Console.WriteLine("What is the word you would like printed when divisible by " + secondNum + "?");
String word2 = Console.ReadLine();
if (maxNumInput != null){
    Int32.TryParse(maxNumInput, out maxNum);
}
var printNum = new Class1(maxNum,word1,word2,firstNum,secondNum);
IEnumerable<String> nums = printNum.printNums();
foreach(String num in nums)
{
    Console.WriteLine(num);
}