using System;
namespace hello;
class String
{
    public static void Main(string[] args)
    {
        string fname = "Ayushi ";
        string lname = "Dalsaniya";
        string name = fname + lname;
        Console.WriteLine(name);

        // concat
        string name1 = string.Concat(fname,lname);
        Console.WriteLine(name1);

        // $ sign 
        string name2 = $"My name is {fname} {lname}";
        Console.WriteLine(name2);

        string name3 = "Ayushi Vipulbhai Dalsaniya";
        Console.WriteLine(name3.ToUpper());

        // substring
        string name4 = "Ayushi Vipulbhai Dalsaniya";
        int lname1 = name4.IndexOf("V");
        var name5 = name4.Substring(lname1);
        Console.WriteLine(name5);
    }
}