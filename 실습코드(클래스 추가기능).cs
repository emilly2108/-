using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Parent
//�޼ҵ� ����� ����
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
//�������̵� �����
{
    public virtual void TakeDamage(int damage)
    {
        Debug.Log($"Entity : {damage}��ŭ ü�°���");
    }
}
public class MovingEntity: Entity
{
    public override void TakeDamage(int damage)
    {
        Debug.Log($"Entity : {damage}��ŭ ü�°���");
    }
}
public class Player : MovingEntity
{
    public override void TakeDamage(int damage)
    {
        Debug.Log($"Entity : {damage}��ŭ ü�°���");
    }
}
*/

//����ü ����
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

        player02.ID = "��ڻ�";
        player02.currentHP = 100000;
        player02.damage = 99999;

        Debug.Log($"{player01.ID},ü�� : {player01.currentHP},���ݷ�:{player01.damage}");
        Debug.Log($"{player02.ID},ü�� : {player02.currentHP},���ݷ�:{player02.damage}");
    }
}
*/
//Ʃ��
/*
var a = ("��ڻ�", 35);
Debug.Log($"{a.Item1}, {a.Item2}");

a.Item2 = 36;
Debug.Log($"{a.Item1},{a.Item2}");
*/

//�������� ����
/*public class Enemy
{
    //�ν��Ͻ� ����
    public int numeric;
    //static����
    public static string species;
}
public class GameController
{
    private void Awake()
    {
        //instance ���� ���
        Enemy enemy01 = new Enemy();
        enemy01.numeric = 0;
        Enemy enemy02 = new Enemy();
        enemy01.numeric = 1;

        Debug.Log(enemy01.numeric);
        Debug.Log(enemy02.numeric);

        //static �������
        Enemy.species = "���";
        Debug.Log(Enemy.species);
    }
}
*/
//Ȯ�� �޼ҵ� ����
/*public static class StringExtension
{
    //ù��° �Ű� ������ Ȯ���Ϸ��� �ϴ� ���
    public static void PrintData(this string str)
    {
        Debug.Log(str);
    }
}*/