using System;
using System.Text;

class AsciiSymbols
{
    static void Main()
    {
        string rowOne = "\u0000 \u0010 \u0020 \u0030 \u0040 \u0050 \u0060 \u0070";
        string rowTwo = "\u0001 \u0011 \u0021 \u0031 \u0041 \u0051 \u0061 \u0071";
        string rowThree = "\u0002 \u0012 \u0022 \u0032 \u0042 \u0052 \u0062 \u0072";
        string rowFour = "\u0003 \u0013 \u0023 \u0033 \u0043 \u0053 \u0063 \u0073";
        string rowFive = "\u0004 \u0014 \u0024 \u0034 \u0044 \u0054 \u0064 \u0074";
        string rowSix = "\u0005 \u0015 \u0025 \u0035 \u0045 \u0055 \u0065 \u0075";
        string rowSeven = "\u0006 \u0016 \u0026 \u0036 \u0046 \u0056 \u0066 \u0076";
        string rowEigh = "\u0007 \u0017 \u0027 \u0037 \u0047 \u0057 \u0067 \u0077";
        string rowNine = "\u0008 \u0018 \u0028 \u0038 \u0048 \u0058 \u0068 \u0078";
        string rowTen = "\u0009 \u0019 \u0029 \u0039 \u0049 \u0059 \u0069 \u0079";
        string rowEleven = "\u000A \u001A \u002A \u003A \u004A \u005A \u006A \u007A";
        string rowTwelve = "\u000B \u001B \u002B \u003B \u004B \u005B \u006B \u007B";
        string rowThirteen = "\u000C \u001C \u002C \u003C \u004C \u005C \u006C \u007C";
        string rowFourteen = "\u000D \u001D \u002D \u003D \u004D \u005D \u006D \u007D";
        string rowFifteen = "\u000E \u001E \u002E \u003E \u004E \u005E \u006E \u007E";
        string rowSixteen = "\u000F \u001F \u002F \u003F \u004F \u005F \u006F \u007F";
        Console.WriteLine(new string ('-', 50) + "\nASCII\n" + new string ('-', 50) +
            "\n{0}\n{1}n{2}\n{3}n{4}\n{5}n{6}\n{7}n{8}\n{9}n{10}\n{11}n{12}\n{13}n{14}\n{15}\n" + new string ('-', 50),
            rowOne, rowTwo,rowThree, rowFour, rowFive, rowSix, rowSeven, rowEigh, rowNine, rowTen, 
            rowEleven, rowTwelve, rowThirteen, rowFourteen, rowFifteen, rowSixteen);
    }
}