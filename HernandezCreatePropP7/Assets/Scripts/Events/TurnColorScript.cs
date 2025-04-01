using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnColorScript : MonoBehaviour
{
    private Renderer rendererDude;
    private void Start()
    {
        rendererDude = GetComponent<Renderer>();
    }

    void OnEnable()
    {
        EventManager.OnClicked += TurnColor;
    }


    void OnDisable()
    {
        EventManager.OnClicked -= TurnColor;
    }

    void TurnColor()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        rendererDude.material.color = col;
    }
}
