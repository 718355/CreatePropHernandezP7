using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit2
{
    public Fruit2()
    {
        Debug.Log("1st Fruit2 Constructor Called.");
    }

    public virtual void Chop()
    {
        Debug.Log("The Fruit2 has been chopped.");
    }

    public virtual void SayHello()
    {
        Debug.Log("Hello, I am a Fruit2.");
    }
}
