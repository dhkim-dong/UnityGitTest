using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullableTest : MonoBehaviour
{
    int? someValue = null;

    // Start is called before the first frame update
    void Start()
    {
        int result = someValue ?? 42;

        Debug.Log(result);
    }   
}
