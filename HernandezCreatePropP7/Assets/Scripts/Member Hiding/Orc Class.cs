using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Enemy2
{
    new public void Yell()
    {
        Debug.Log("Orc version of the Yell() method");
    }
}
