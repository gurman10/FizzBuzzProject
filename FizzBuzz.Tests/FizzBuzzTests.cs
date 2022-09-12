using System.Collections;
using NUnit.Framework;

namespace FizzBuzz.Tests;

[TestFixture(Author = "Gurman Deep Singh")]
public class FizzBuzzTests
{ 
    [Test]
    public void When_Mutiple_Of_3_Expect_Fizz()
    {
        string expected = "Fizz";
        var actual = Program.FizzBuzzIt(9);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void When_Multiple_Of_5_Expect_Buzz()
    {
        string expected = "Buzz";
        var actual = Program.FizzBuzzIt(25);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void When_Multiple_Of_Both_3_And_5_Expect_FizzBuzz()
    {
        string expected = "FizzBuzz";
        var actual = Program.FizzBuzzIt(15);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void When_Not_A_Multiple_Of_3_Or_5_Expect_Same_Number()
    {
        string expected = "26";
        var actual = Program.FizzBuzzIt(26);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Output_Of_1_To_100()
    {
        ICollection expected = new ArrayList {"1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz", "16", "17", "Fizz", "19", "Buzz", "Fizz", "22", "23", "Fizz", "Buzz", "26", "Fizz", "28", "29", "FizzBuzz", "31", "32", "Fizz", "34", "Buzz", "Fizz", "37", "38", "Fizz", "Buzz", "41", "Fizz", "43", "44", "FizzBuzz", "46", "47", "Fizz", "49", "Buzz", "Fizz", "52", "53", "Fizz", "Buzz", "56", "Fizz", "58", "59", "FizzBuzz", "61", "62", "Fizz", "64", "Buzz", "Fizz", "67", "68", "Fizz", "Buzz", "71", "Fizz", "73", "74", "FizzBuzz", "76", "77", "Fizz", "79", "Buzz", "Fizz", "82", "83", "Fizz", "Buzz", "86", "Fizz", "88", "89", "FizzBuzz", "91", "92", "Fizz", "94", "Buzz", "Fizz", "97", "98", "Fizz", "Buzz"};
        var actual = Enumerable.Range(1, 100).Select(x => Program.FizzBuzzIt(x)).ToList();

        Assert.That(actual, Is.EqualTo(expected));
    }
}