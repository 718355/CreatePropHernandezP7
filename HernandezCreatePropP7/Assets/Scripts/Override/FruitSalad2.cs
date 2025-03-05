using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad2 : MonoBehaviour
{
    void Start()
    {
        Apple2 myApple = new Apple2();

        myApple.SayHello();
        myApple.Chop();

        Fruit2 myFruit = new Apple2();
        myFruit.SayHello();
        myFruit.Chop();
    }
}
