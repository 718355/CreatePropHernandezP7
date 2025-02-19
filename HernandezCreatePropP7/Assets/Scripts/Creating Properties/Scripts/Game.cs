using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    void Start()
    {
        Player myPlayer = new Player();

        myPlayer.Expirence = 5;
        int x = myPlayer.Expirence;
    }
}
