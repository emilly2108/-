using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Player
// ���� ���а� ĸ��ȭ
{
    private int currentHP;

    public void SetCurrentHP(int hp)
    {
        if (hp > 0)
        {
            currentHP = hp;
        }
    }

    public int GetCurrentHP()
    {
        return currentHP;
    }
}*/

/*public class Entity
//���
{
    public string ID;
    protected int currentHP;

    private void Initialize()
    {
        ID = "Noname";
    }

    public void RecoveryHP(int hp)
    {
        currentHP += hp;
    }
}*/

/*public class Entity
//������
{
    public void Attack()
    {
        Debug.Log("���� �����Ѵ�");
    }

    public void Heal()
    {
        Debug.Log("ü���� ȸ���Ѵ�.");
    }
}

public class Goblin : Entity
{
    public void Avoid()
    {
        Debug.Log("��������!!");
    }

    public void Heal()
    {
        Debug.Log("����� ü��ȸ��");
    }
}*/

/*public class Goblin
//��ĳ����
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"��� : (damage)��ŭ ü�� ����");
    }
}
public class Slime
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"������ : (damage)��ŭ ü�� ����");
    }
}
public class Dragon
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"�巡�� : (damage)��ŭ ü�� ����");
    }
}*/

//�߻�Ŭ���� ����
/*public abstract class Entity
{
    protected int damage;
    protected int currentHP;

    public abstract void Attack(Entity target);
    public void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
            Debug.Log($"ü���� {damage} ����");
        }
        else
        {
            Debug.Log("Die");
        }
    }
}*/
