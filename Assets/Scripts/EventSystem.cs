using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    public static event Action<int> OnScoreChanged;                 //���ھ� ��ȯ Action ���
    public static event Action OnGameOver;                          //���� ���� Action ���

    private int score = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score += 10;
            OnScoreChanged?.Invoke(score); ;                        //���ھ� ������ ȣ��
        }
        if (score >= 100)
        {
            OnGameOver?.Invoke();                                   //���� ������ ȣ�� 
        }
    }
}
