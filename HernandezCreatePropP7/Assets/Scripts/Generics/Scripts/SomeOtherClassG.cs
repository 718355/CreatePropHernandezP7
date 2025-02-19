using System.Collections;
using UnityEngine;

public class SomeOtherClassG : MonoBehaviour
{
    void Start()
    {
        SomeClass myClass = new SomeClass();


        myClass.GenericMethod<int>(5);
    }
}
