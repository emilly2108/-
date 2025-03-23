using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Player
// 정보 은닉과 캡슐화
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
//상속
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
//다형성
{
    public void Attack()
    {
        Debug.Log("적을 공겨한다");
    }

    public void Heal()
    {
        Debug.Log("체력을 회복한다.");
    }
}

public class Goblin : Entity
{
    public void Avoid()
    {
        Debug.Log("도망가자!!");
    }

    public void Heal()
    {
        Debug.Log("고블린의 체력회복");
    }
}*/

/*public class Goblin
//업캐스팅
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"고블린 : (damage)만큼 체력 감소");
    }
}
public class Slime
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"슬라임 : (damage)만큼 체력 감소");
    }
}
public class Dragon
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"드래곤 : (damage)만큼 체력 감소");
    }
}*/

//추상클래스 예시
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
            Debug.Log($"체력이 {damage} 감소");
        }
        else
        {
            Debug.Log("Die");
        }
    }
}*/
