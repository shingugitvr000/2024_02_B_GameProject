using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCallback : MonoBehaviour
{
    private Action greetingAction;              //�׼� ���� 
  
    void Start()
    {
        greetingAction = SayHello;              //Action �Լ� �Ҵ�
        PerformGreeting(greetingAction);
    }

    void SayHello()
    {
        Debug.Log("Hello, world!");
    }

    void PerformGreeting(Action greetingFunc)
    {
        greetingFunc?.Invoke();
    }  
}
