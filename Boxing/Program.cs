using System.Collections;
using System;
using System.Collections.Generic;

class program
{
    static void Main(string[] args)
    {
        var List = new ArrayList();
        List.Add(1); // BOXING CAN HAPPEN ITS AN INTEGER
        List.Add("Lihle"); // WONT HAPPEN SINCE ITS A STRING 
        List.Add(DateTime.Today); // BOXING CAN HAPPEN SINCE ITS A VALUE TYPE 

        var anootherList = new List<int>(); // use generic method of stringd
        var names = new List<string>();
        names.Add("a"); // i.e no boxing 

    }
}