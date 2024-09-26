using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��ü���� Ÿ�� Ŭ���� 
public class PlayerTarget : MonoBehaviour , ISkillTarget
{
    public int Health { get; set; } = 100;

    public void ApplyEffect(ISkillEffect effect)
    {
        effect.Apply(this);
    }
}
