using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WarBand : MonoBehaviour
{
    private void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new Enemy2();
        Humanoid orc = new Orc();

        human.Yell();
        human.Yell();
        orc.Yell();
    }
}
