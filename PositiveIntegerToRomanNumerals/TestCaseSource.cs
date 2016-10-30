using System.Collections.Generic;

namespace CodingChallenges_CSharp.PositiveIntegerToRomanNumerals
{
    public static class TestCaseSource
    {
        public static IEnumerable<object[]> GetTests()
        {
            yield return new object[] { 1, 0, "nulla" };
            yield return new object[] { 2, 1, "I" };
            yield return new object[] { 3, 2, "II" };
            yield return new object[] { 4, 3, "III" };
            yield return new object[] { 5, 4, "IV" };
            yield return new object[] { 6, 5, "V" };
            yield return new object[] { 7, 6, "VI" };
            yield return new object[] { 8, 7, "VII" };
            yield return new object[] { 9, 8, "VIII" };
            yield return new object[] { 10, 9, "IX" };
            yield return new object[] { 11, 10, "X" };
            yield return new object[] { 12, 11, "XI" };
            yield return new object[] { 13, 12, "XII" };
            yield return new object[] { 14, 13, "XIII" };
            yield return new object[] { 15, 14, "XIV" };
            yield return new object[] { 16, 15, "XV" };
            yield return new object[] { 17, 16, "XVI" };
            yield return new object[] { 18, 17, "XVII" };
            yield return new object[] { 19, 18, "XVIII" };
            yield return new object[] { 20, 19, "XIX" };
            yield return new object[] { 21, 20, "XX" };
            yield return new object[] { 22, 21, "XXI" };
            yield return new object[] { 23, 22, "XXII" };
            yield return new object[] { 24, 23, "XXIII" };
            yield return new object[] { 25, 24, "XXIV" };
            yield return new object[] { 26, 25, "XXV" };
            yield return new object[] { 27, 26, "XXVI" };
            yield return new object[] { 28, 27, "XXVII" };
            yield return new object[] { 29, 28, "XXVIII" };
            yield return new object[] { 30, 29, "XXIX" };
            yield return new object[] { 31, 30, "XXX" };
            yield return new object[] { 32, 31, "XXXI" };
            yield return new object[] { 33, 32, "XXXII" };
            yield return new object[] { 34, 33, "XXXIII" };
            yield return new object[] { 35, 34, "XXXIV" };
            yield return new object[] { 36, 35, "XXXV" };
            yield return new object[] { 37, 36, "XXXVI" };
            yield return new object[] { 38, 37, "XXXVII" };
            yield return new object[] { 39, 38, "XXXVIII" };
            yield return new object[] { 40, 39, "XXXIX" };
            yield return new object[] { 41, 40, "XL" };
            yield return new object[] { 42, 41, "XLI" };
            yield return new object[] { 43, 42, "XLII" };
            yield return new object[] { 44, 43, "XLIII" };
            yield return new object[] { 45, 44, "XLIV" };
            yield return new object[] { 46, 45, "XLV" };
            yield return new object[] { 47, 46, "XLVI" };
            yield return new object[] { 48, 47, "XLVII" };
            yield return new object[] { 49, 48, "XLVIII" };
            yield return new object[] { 50, 49, "XLIX" };
            yield return new object[] { 51, 50, "L" };
            yield return new object[] { 52, 51, "LI" };
            yield return new object[] { 53, 52, "LII" };
            yield return new object[] { 54, 53, "LIII" };
            yield return new object[] { 55, 54, "LIV" };
            yield return new object[] { 56, 55, "LV" };
            yield return new object[] { 57, 56, "LVI" };
            yield return new object[] { 58, 57, "LVII" };
            yield return new object[] { 59, 58, "LVIII" };
            yield return new object[] { 60, 59, "LIX" };
            yield return new object[] { 61, 60, "LX" };
            yield return new object[] { 62, 61, "LXI" };
            yield return new object[] { 63, 62, "LXII" };
            yield return new object[] { 64, 63, "LXIII" };
            yield return new object[] { 65, 64, "LXIV" };
            yield return new object[] { 66, 65, "LXV" };
            yield return new object[] { 67, 66, "LXVI" };
            yield return new object[] { 68, 67, "LXVII" };
            yield return new object[] { 69, 68, "LXVIII" };
            yield return new object[] { 70, 69, "LXIX" };
            yield return new object[] { 71, 70, "LXX" };
            yield return new object[] { 72, 71, "LXXI" };
            yield return new object[] { 73, 72, "LXXII" };
            yield return new object[] { 74, 73, "LXXIII" };
            yield return new object[] { 75, 74, "LXXIV" };
            yield return new object[] { 76, 75, "LXXV" };
            yield return new object[] { 77, 76, "LXXVI" };
            yield return new object[] { 78, 77, "LXXVII" };
            yield return new object[] { 79, 78, "LXXVIII" };
            yield return new object[] { 80, 79, "LXXIX" };
            yield return new object[] { 81, 80, "LXXX" };
            yield return new object[] { 82, 81, "LXXXI" };
            yield return new object[] { 83, 82, "LXXXII" };
            yield return new object[] { 84, 83, "LXXXIII" };
            yield return new object[] { 85, 84, "LXXXIV" };
            yield return new object[] { 86, 85, "LXXXV" };
            yield return new object[] { 87, 86, "LXXXVI" };
            yield return new object[] { 88, 87, "LXXXVII" };
            yield return new object[] { 89, 88, "LXXXVIII" };
            yield return new object[] { 90, 89, "LXXXIX" };
            yield return new object[] { 91, 90, "XC" };
            yield return new object[] { 92, 91, "XCI" };
            yield return new object[] { 93, 92, "XCII" };
            yield return new object[] { 94, 93, "XCIII" };
            yield return new object[] { 95, 94, "XCIV" };
            yield return new object[] { 96, 95, "XCV" };
            yield return new object[] { 97, 96, "XCVI" };
            yield return new object[] { 98, 97, "XCVII" };
            yield return new object[] { 99, 98, "XCVIII" };
            yield return new object[] { 100, 99, "XCIX" };
            yield return new object[] { 101, 100, "C" };

            yield return new object[] { 102, 864, "DCCCLXIV" };
            yield return new object[] { 103, 358, "CCCLVIII" };
            yield return new object[] { 104, 112, "CXII" };
            yield return new object[] { 105, 700, "DCC" };
            yield return new object[] { 106, 999, "CMXCIX" };
            yield return new object[] { 107, 227, "CCXXVII" };
            yield return new object[] { 108, 492, "CDXCII" };
            yield return new object[] { 109, 602, "DCII" };
            yield return new object[] { 110, 313, "CCCXIII" };
            yield return new object[] { 111, 316, "CCCXVI" };

            yield return new object[] { 112, 1000, "M" };
            yield return new object[] { 113, 3963, "MMMCMLXIII" };
            yield return new object[] { 114, 1020, "MXX" };
            yield return new object[] { 115, 4999, "MMMMCMXCIX" };
            yield return new object[] { 116, 4005, "MMMMV" };
            yield return new object[] { 117, 1007, "MVII" };
            yield return new object[] { 118, 2273, "MMCCLXXIII" };
            yield return new object[] { 118, 3069, "MMMLXIX" };
            yield return new object[] { 120, 2481, "MMCDLXXXI" };
            yield return new object[] { 121, 2088, "MMLXXXVIII" };

            yield return new object[] { 113, 200, "CC" };
            yield return new object[] { 114, 300, "CCC" };
            yield return new object[] { 115, 400, "CD" };
            yield return new object[] { 116, 500, "D" };
            yield return new object[] { 117, 600, "DC" };
            yield return new object[] { 118, 700, "DCC" };
            yield return new object[] { 118, 800, "DCCC" };
            yield return new object[] { 120, 900, "CM" };

            yield return new object[] { 112, 1000, "M" };
            yield return new object[] { 113, 2000, "MM" };
            yield return new object[] { 114, 3000, "MMM" };
            yield return new object[] { 115, 4000, "MMMM" };
        } 
    }
}