using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxintTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Add(3, 5, "�ڽ��� ���Ǵ� ����");
    }

   
    void Add(int a) { }
    void Add(int a, int b) { }
    void Add(int a, int b, int c) { }
    void Add(params object[] values) 
    {
        foreach(object o in values)
        {
            Debug.Log($"�Է� ���� ��� Ÿ���� ��� : Ÿ�� :{o.GetType()} �̸� :{o.ToString()}");
        }
    }
}
