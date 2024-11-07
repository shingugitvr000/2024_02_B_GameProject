using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame.QuestSystem
{
    public class CollectionQuestCondition : IQuestCondition     //�������� �����ϴ� ����Ʈ ������ ���� �ϴ� Ŭ����
    {
        private string itemId;                  //�����ؾ� �� ������ ID
        private int requiredAmount;             //�����ؾ� �� ������ ����
        private int currentAmount;              //������� ������ ������ ����
        public CollectionQuestCondition(string itemId, int requiredAmount)  //�����ڿ��� ������ ID�� �ʿ��� ������ ���� 
        {
            this.itemId = itemId;
            this.requiredAmount = requiredAmount;
            this.currentAmount = 0;
        }

        public bool IsMet() => currentAmount > requiredAmount;                  //����Ʈ ������ �����Ǿ����� ���� Ȯ��
        public void Initialize() => currentAmount = 0;                          //������ �ʱ�ȭ �Ͽ� ������ 0
        public float GetProgress() => (float)currentAmount / requiredAmount;    //���� ���� ��Ȳ�� 0���� 1������ ������ ��ȯ
        public string GetDescription() => $"Defeat {requiredAmount} {itemId} ({currentAmount}/{requiredAmount})";   //����Ʈ ���� ������ ���ڿ��� ��ȯ

        public void ItemCollected(string itemId)
        {
            if (this.itemId == itemId)
            {
                currentAmount++;
            }
        }       
    }
}