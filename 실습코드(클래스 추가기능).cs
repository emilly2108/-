using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Parent
//메소드 숨기기 예시
{
    public void Method01()
    {
        Debug.Log("Parent");
    }
}

public class Child : Parent
{
    public void Method01()
    {
        Debug.Log("Child");
    }
}

public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Parent p = new Parent();
        p.Method01();

        Child c = new Child();
        c.Method01();

        Parent pc = new Child();
        pc.Method01();
    }
}*/

/*public class Entity
//오버라이딩 숨기기
{
    public virtual void TakeDamage(int damage)
    {
        Debug.Log($"Entity : {damage}만큼 체력감소");
    }
}
public class MovingEntity: Entity
{
    public override void TakeDamage(int damage)
    {
        Debug.Log($"Entity : {damage}만큼 체력감소");
    }
}
public class Player : MovingEntity
{
    public override void TakeDamage(int damage)
    {
        Debug.Log($"Entity : {damage}만큼 체력감소");
    }
}
*/

//구조체 예시
/*
 public struct stats
{
    public string ID;
    public int currentHP;
    public int damage;
}
public class GameController : MonoBehaviour
{
    private void Awake()
    {
        stats player01 = new stats();
        stats player02;

        player02.ID = "고박사";
        player02.currentHP = 100000;
        player02.damage = 99999;

        Debug.Log($"{player01.ID},체력 : {player01.currentHP},공격력:{player01.damage}");
        Debug.Log($"{player02.ID},체력 : {player02.currentHP},공격력:{player02.damage}");
    }
}
*/
//튜플
/*
var a = ("고박사", 35);
Debug.Log($"{a.Item1}, {a.Item2}");

a.Item2 = 36;
Debug.Log($"{a.Item1},{a.Item2}");
*/

//정적변수 예시
/*public class Enemy
{
    //인스턴스 변수
    public int numeric;
    //static변수
    public static string species;
}
public class GameController
{
    private void Awake()
    {
        //instance 변수 사용
        Enemy enemy01 = new Enemy();
        enemy01.numeric = 0;
        Enemy enemy02 = new Enemy();
        enemy01.numeric = 1;

        Debug.Log(enemy01.numeric);
        Debug.Log(enemy02.numeric);

        //static 변수사용
        Enemy.species = "고블린";
        Debug.Log(Enemy.species);
    }
}
*/
//확장 메소드 예시
/*public static class StringExtension
{
    //첫번째 매개 변수는 확장하려고 하는 대상
    public static void PrintData(this string str)
    {
        Debug.Log(str);
    }
}*/