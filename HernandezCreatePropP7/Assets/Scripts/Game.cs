using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private int x;
    public Player myPlayer;
    private void Start()
    {

        myPlayer.Expirence = 5;
        x = myPlayer.Expirence;
    }
}
