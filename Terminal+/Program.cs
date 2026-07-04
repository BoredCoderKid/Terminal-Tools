using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

//List, UI setup & variables
var UI_list = new List<int> {1, 2, 3, 4, 5};
int selector = 1;
string currentdir = Directory.GetCurrentDirectory();

while (true){
    try {
//Calc UI
string calc = $"""
     ________________
    |                |
    |   Calculator   |
    |________________|
    """;

Console.WriteLine(calc);

//Extra Info UI
string extra_info = $"""
 ________________
|                |
|   Extra Info   |
|________________|
""";

Console.WriteLine(extra_info);

//Text UI
string text_maker = $"""
 ________________
|                |
|   Text Maker   |
|________________|
""";

Console.WriteLine(text_maker);

//||-------------------------------------------------------||

//Listener
ConsoleKeyInfo keyInput = Console.ReadKey(intercept: false);

//D keybind
if (keyInput.Key == ConsoleKey.D){
    selector += 1 ;
    if (selector == 0 || selector == 4){
        selector = 1;
    }
}

//A keybind
if (keyInput.Key == ConsoleKey.A){
    selector -= 1 ;
    if (selector == 0 || selector == 4){
        selector = 1;
    }
}

//Calculator selector
if (selector == 1){
    Console.Clear();
    Console.WriteLine("Calculator?");
}

//Extra Info selector
if (selector == 2){
    Console.Clear();
    Console.WriteLine("Extra Info?");
}

//Text Maker selector
if (selector == 3){
    Console.Clear();
    Console.WriteLine("Text Maker?");
};

//Calculator selector
if (selector == 1){
    Console.Clear();
    Console.WriteLine("Calculator?");
}

//Extra Info selector
if (selector == 2){
    Console.Clear();
    Console.WriteLine("Extra Info?");
}

//Text Maker selector
if (selector == 3){
    Console.Clear();
    Console.WriteLine("Text Maker?");
};

//exit
if (keyInput.Key == ConsoleKey.Escape){
    return;
}
//||_______________________________________||

//ui thingy
if (keyInput.Key == ConsoleKey.Enter){
    //calculator
    if (selector == 1){
        Console.Clear();

        //First number
        Console.WriteLine("Whats your first number?");
        string num1string = Console.ReadLine();
        long num1int = Convert.ToInt64(num1string);
        Console.Clear();

        //Sign
        Console.WriteLine("Whats your sign? (*, /, +, - & %)");
        string sign_number = Console.ReadLine();
        Console.Clear();

        //Second number
        Console.WriteLine("Whats your second number?");
        string num2string = Console.ReadLine();
        long num2int = Convert.ToInt64(num2string);
        Console.Clear();

        //if chain for signs
        //plus check
        if (sign_number == "+"){
            Console.Clear();
            Console.WriteLine($"Your final equation: {num1int + num2int}");
        };

        //times check
        if (sign_number == "*"){
            Console.Clear();
            Console.WriteLine($"Your final equation: {num1int * num2int}");
        };

        //minus check
        if (sign_number == "-"){
            Console.Clear();
            Console.WriteLine($"Your final equation: {num1int - num2int}");
        };

        //deviding check
        if (sign_number == "/"){
            Console.Clear();
            Console.WriteLine($"Your final equation {num1int / num2int}");
        };

        //percentage check
        if (sign_number == "%"){
            Console.Clear();
            Console.WriteLine($"Your final equation {num1int % num2int}");
        };

    }
    //Extra Info
    if (selector ==2){
        Console.Clear();
        string extra_info_string = $"""
         --- Extra Info ---
        *A moves to the left
        *D moves to the right
        *Enter selects the current ui
        """;

        Console.WriteLine(extra_info_string);
    }

    //Text Maker selector
    if (selector == 3){
        Console.Clear();
        Console.WriteLine("Type your text, when you press enter it'll save into your computer as a txt file.");
        string text_input = Console.ReadLine();
        Console.Clear();
        File.WriteAllText($"{currentdir}.txt", text_input);
        Console.WriteLine($"Text saved in: {currentdir} !");
    }
};
}

//calculator error catcher
catch (FormatException){
    Console.Clear();
    Console.WriteLine("Calculator Error: FormatException");
}

catch (OverflowException){
    Console.Clear();
    Console.WriteLine("Calculator Error: OverFlowException");
}

//file error catcher
catch (ArgumentException){
    Console.Clear();
    Console.WriteLine("File Error: ArgumentException");
}

catch (PathTooLongException){
    Console.Clear();
    Console.WriteLine("File Error: PathTooLongException");
}

catch (DirectoryNotFoundException){
    Console.Clear();
    Console.WriteLine("File Error: DirectoryNotFoundException");
}

catch (IOException){
    Console.Clear();
    Console.WriteLine("File Error: IOException");
}

catch (UnauthorizedAccessException){
    Console.Clear();
    Console.WriteLine("File Error: UnauthorizedAccessException");
}

catch (NotSupportedException){
    Console.Clear();
    Console.WriteLine("File Error: NotSupportedException");
}

catch (System.Security.SecurityException){
    Console.Clear();
    Console.WriteLine("File Error: System.Security.SecurityException");
}

//this is to shut up errors i dont want clogging up the terminal
catch (Exception){
    Console.WriteLine("");
    Console.Clear();
};
};