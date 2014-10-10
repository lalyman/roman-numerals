using NUnit.Framework;

namespace RomanNumerals
{
    [TestFixture]
    public class RomanNumeralsTests
    {
 
        [Test]
        public void BlankNumeral()
        {
            const int number = 0;
            Assert.That(number.Roman(), Is.EquivalentTo(string.Empty));
        }

        [Test]
        public void One()
        {
            const int number = 1;
            Assert.That(number.Roman(), Is.EquivalentTo("I"));
        }
        [Test]
        public void Three()
        {
            const int number = 3;
            Assert.That(number.Roman(), Is.EquivalentTo("III"));
        }
        public void Four()
        {
            const int number = 4;
            Assert.That(number.Roman(), Is.EquivalentTo("IV"));
        }
        [Test]
        public void Six()
        {
            const int number = 6;
            Assert.That(number.Roman(), Is.EquivalentTo("VI"));
        }
        [Test]
        public void Eight()
        {
            const int number = 8;
            Assert.That(number.Roman(), Is.EquivalentTo("VIII"));
        }
        [Test]
        public void Nine()
        {
            const int number = 9;
            Assert.That(number.Roman(), Is.EquivalentTo("IX"));
        }
        [Test]
        public void Ten()
        {
            const int number = 10;
            Assert.That(number.Roman(), Is.EquivalentTo("X"));
        }
        [Test]
        public void Nineteen()
        {
            const int number = 19;
            Assert.That(number.Roman(), Is.EquivalentTo("XIX"));
        }

        [Test]
        public void TwentySeven()
        {
            const int number = 27;
            Assert.That(number.Roman(), Is.EquivalentTo("XXVII"));
        } 
        [Test]
        public void Thirty()
        {
            const int number = 30;
            Assert.That(number.Roman(), Is.EquivalentTo("XXX"));
        }
        [Test]
        public void ThirtyFour()
        {
            const int number = 34;
            Assert.That(number.Roman(), Is.EquivalentTo("XXXIV"));
        }
        [Test]
        public void FortySeven()
        {
            const int number = 47;
            Assert.That(number.Roman(), Is.EquivalentTo("XLVII"));
        }
        [Test]
        public void FiftySix()
        {
            const int number = 56;
            Assert.That(number.Roman(), Is.EquivalentTo("LVI"));
        }
        [Test]
        public void SeventyNine()
        {
            const int number = 79;
            Assert.That(number.Roman(), Is.EquivalentTo("LXXIX"));
        }
        [Test]
        public void EightySeven()
        {
            const int number = 87;
            Assert.That(number.Roman(), Is.EquivalentTo("LXXXVII"));
        }
        [Test]
        public void OneHundredNintyNine()
        {
            const int number = 199;
            Assert.That(number.Roman(), Is.EquivalentTo("CXCIX"));
        }
        [Test]
        public void ThreeHundredTwentySix()
        {
            const int number = 324;
            Assert.That(number.Roman(), Is.EquivalentTo("CCCXXIV"));
        }
        [Test]
        public void FourHundredNintyNine()
        {
            const int number = 499;
            Assert.That(number.Roman(), Is.EquivalentTo("CDXCIX"));
        }
        [Test]
        public void SevenHundredFourteen()
        {
            const int number = 714;
            Assert.That(number.Roman(), Is.EquivalentTo("DCCXIV"));
        }
        [Test]
        public void NineHundred()
        {
            const int number = 900;
            Assert.That(number.Roman(), Is.EquivalentTo("CM"));
        }
        [Test]
        public void NineHundredFiftyThree()
        {
            const int number = 953;
            Assert.That(number.Roman(), Is.EquivalentTo("CMLIII"));
        }
        [Test]
        public void OneThousandNineHundredNinty()
        {
            const int number = 1990;
            Assert.That(number.Roman(), Is.EquivalentTo("MCMXC"));
        }
        [Test]
        public void TwoThousandAndEight()
        {
            const int number = 2008;
            Assert.That(number.Roman(), Is.EquivalentTo("MMVIII"));
        }
        
    }

    public static class RomanNumeralsExtension
    {
        public static string Roman(this int number)
        {

            int[] importantnumbers = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            var tmp = string.Empty;

            for (int i = 0; i < importantnumbers.Length; i++)
            {
                while (number >= importantnumbers[i])
                {
                    tmp += symbols[i];
                    number -= importantnumbers[i];
                }
            }
            return tmp;

        }

    }

}
