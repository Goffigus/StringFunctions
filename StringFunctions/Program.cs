using System;
using static System.Console;
namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string stuff = "           \nThe rapier, a long double-edged weapon, with " +
                "ample \"quillons\" and \"counterguards,\" \nwhich latter afterwards " +
                "assumed the form of a cup, \nwas held in the right hand with the " +
                "forefinger crossed over the \"quillon.\"";
            WriteLine(stuff);
            stuff = stuff.Trim();
            WriteLine(stuff);

            int position = stuff.IndexOf("rapier");
            WriteLine(position);

            position = stuff.IndexOf("long sword"); //postion of a word that is not in the string
            WriteLine(position);

            //example of replacing a word
            position = stuff.IndexOf("rapier");
            WriteLine(position);

            //remove(position, length of word)
             stuff = stuff.Remove(position, 6); //removes rapier 1 time
            WriteLine(stuff);
            stuff = stuff.Insert(position, "long-pointy-killing thing");
            WriteLine(stuff);

            //loop that finds all instance of a word in a string and replaces them
            while(stuff.IndexOf("quillon") > -1)
            {
                position = stuff.IndexOf("quillon");
       
                stuff = stuff.Remove(position, 7);
                stuff = stuff.Insert(position, "finger holdy/guardy thing");
            }

            WriteLine(stuff);



        }
    }
}
