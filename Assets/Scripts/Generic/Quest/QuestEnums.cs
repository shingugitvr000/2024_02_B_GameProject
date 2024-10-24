using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame.QuestSystem
{   
    public enum QuestStatus              //����Ʈ�� ���� ���¸� ��Ÿ���� ������
    {
        NotStarted,                     //����Ʈ�� ���� ���۵��� ���� ����
        InProgress,                     //����Ʈ�� ���� ���� ���� ����
        Completed,                      //����Ʈ�� �Ϸ�� ����
        Failed                          //����Ʈ�� ������ ����
    }

    public enum QuestType               //����Ʈ�� ������ �����ϴ� ������
    {
        Collection,                     //�������� �����ϴ� ����Ʈ
        Kill,                           //���͸� óġ�ϴ� ����Ʈ
        Dialog,                         //NPC�� ��ȭ�ϴ� ����Ʈ
        Exploration,                    //Ư�� ������ Ž���ϴ� ����Ʈ 
        Escort                          //NPC�� ��ȣ/ȣ�� �ϴ� ����Ʈ 
    }
}