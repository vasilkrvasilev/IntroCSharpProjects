using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        string triangle = "\n  \u00A9  \n \u00A9\u00A9\u00A9 \n\u00A9\u00A9\u00A9\u00A9\u00A9\n";               //Copyright sign
        Console.WriteLine(triangle);
        string triangleSubstituteOne = "\n  \u24B8  \n \u24B8\u24B8\u24B8 \n\u24B8\u24B8\u24B8\u24B8\u24B8\n";  //Circled latin capital letter C
        Console.WriteLine(triangleSubstituteOne);
        string triangleSubstituteTwo = "\n  \u24D2  \n \u24D2\u24D2\u24D2 \n\u24D2\u24D2\u24D2\u24D2\u24D2\n";  //Circled latin small letter c
        Console.WriteLine(triangleSubstituteTwo);
    }
}