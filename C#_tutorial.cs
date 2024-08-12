//------------------------------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------------------------------


//Basics Commands

///*To output a word or something we use this: */
Console.Write("This is how it written");
//the code above is a code that output something but with this format if you add another it will just go on the same line like this:
Console.Write("This is the First Word");
Console.Write("This is the second word");
//To solve this issue you may use WriteLine to automatically put the next output on the next line
Console.WriteLine("Hello");
Console.WriteLine("HI");
//but as seen in output the Hello is on the Line for second word because it is a Write and not Writeline
//To solve this issue we can use \n for example this
Console.Write("Nice to met ya");
Console.Write("\nWhats up");
//spacing if you click a lot of space obviously it will be read too
Console.WriteLine("      helloo      helloo");
//but we can use \t to shorten it like this
Console.WriteLine("\tMuch \tBetter sup");
//The \a is a bell that produce sounds when called like this
Console.WriteLine("\ahi");
//Console.WriteLine(); can be also use for making new line like \n so choose wisely which can make the code more readable
Console.WriteLine();
Console.Write("\n");
Console.WriteLine("My my");
//the \r is use to overwrite the first words (before the \r)
Console.WriteLine("Howdy \rHello There");
// by adding a \\ we could show a \
Console.WriteLine("4\\5 is what?");
// and now by putting a /"/" whatever is inside it will be between ""
Console.WriteLine("He said \"Hello My Guy\"");
//we could also put a (Copyright symbol) using the "\u00A9" as \u is a unicode with 4 code point
Console.WriteLine("My Song \u00A9");//may not work on some
// the \U is for 8 code point
Console.WriteLine("\U0001F600");//may also not work on some
// by using \b we can backspace a letter
Console.WriteLine("Hello\b");
//Console.ReadKey is use for a pause same as Console.Read but with slightly different
Console.ReadKey();//any key top continue
Console.WriteLine("Continuing");
Console.Read();//pres any key then enter to continue
//Console.Clear is for clearing the terminal in case you want to display other thing while making the look as clear
Console.Clear();
Console.WriteLine("New Start");
