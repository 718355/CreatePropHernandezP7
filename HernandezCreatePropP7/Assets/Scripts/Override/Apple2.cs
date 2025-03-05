using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple2 : Fruit2
{
    public Apple2()
    {
        Debug.Log("1st Apple Contructor Called");
    }

    public override void Chop()
    {
        base.Chop();
        Debug.Log("The Apple has been chopped.");
    }

    public override void SayHello()
    {
        base.SayHello();
        Debug.Log("Hello, I am an apple.");
    }
}
