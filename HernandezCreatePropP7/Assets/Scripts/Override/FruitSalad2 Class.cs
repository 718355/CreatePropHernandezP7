using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad2 : MonoBehaviour
{
    private void Start()
    {
        Apple2 myApple = new Apple2();

        myApple.SayHello();
        myApple.Chop();

        Fruit myFruit = new Apple();
        myFruit.SayHello();
        myFruit.Chop();
    }


    
}
