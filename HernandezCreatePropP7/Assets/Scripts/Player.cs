using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int expirence;

    public int Expirence
    {
        get
        {
            return expirence;

        }
        set
        {
            expirence = value;
        }
    }
    public int level
    {
        get
        {
            return expirence / 1000;
        }
        set
        {
            expirence = value * 1000;
        }
    }
    public int Health { get; set; }
    

}
