using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxintTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Add(3, 5, "박싱이 사용되는 예시");
    }

   
    void Add(int a) { }
    void Add(int a, int b) { }
    void Add(int a, int b, int c) { }
    void Add(params object[] values) 
    {
        foreach(object o in values)
        {
            Debug.Log($"입력 받은 모든 타입을 출력 : 타입 :{o.GetType()} 이름 :{o.ToString()}");
        }
    }
}
