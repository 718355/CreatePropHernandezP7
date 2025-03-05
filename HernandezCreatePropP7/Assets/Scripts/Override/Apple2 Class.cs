using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple2 : Fruit2
{
    public Apple2()
    {
        Debug.Log("1st Fruit2 Constructor Called.");
    }

    public override void Chop()
    {
        base.Chop();
        Debug.Log("The apple2 has been chopped.");
    }

    public override void SayHello()
    {
        Debug.Log("Hello, I am a apple2.");
    }
}
