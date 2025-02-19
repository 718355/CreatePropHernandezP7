using System.Collections;
using UnityEngine;

public class SomeOtherClassG : MonoBehaviour
{
    void Start()
    {
        SomeClassG myClass = new SomeClassG();


        myClass.GenericMethod<int>(5);
    }
}
