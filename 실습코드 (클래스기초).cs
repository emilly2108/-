using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Player : MonoBehaviour
//��� �Լ�
{
    private string ID = " ��ڻ�";
    private int currentHP = 1000;

    private void Awake()
    {
        TakeDamage(100);
    }
    public void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
        }
    }
}
*/

/*public class Player : MonoBehaviour
//���� ������ ����
{
    private string ID;
    private int currentHP;

    void RecoveryHP(int hp)
    {
        currentHP += hp;
    }
    public void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
        }
    }
}
*/


/*public class GameController : MonoBehaviour
//Ŭ���� ��ü ����
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player01 = new Player();
        player01.TakeDamage(100);
        player02.TakeDamage(200);
    }
}
*/

/*public class GameController : MonoBehaviour
{
//������(new�� �޸� �Ҵ��� ��)
    public class Player : MonoBehaviour
    {
        public Player player01;

        private void Awake()
        {
            player01 = new Player();
        }
    }
}*/

/*public class Player
    // ������ �޼ҵ� �����ε�
{
    public string ID;
    private int currentHP;
    
    public Player()
    {
        ID = "��ڻ�";
        currentHP = 1000;
    }

    public Player(string id, int hp)
    {
        ID = id;
        currentHP = hp;
    }
}*/

 /*public class Player
    //this ������
{
    private string ID;
    private int currentHP;
    private int currntMP;           

    public Player()
    {
        ID = "��ڻ�";
    }
    public Player(int hp) : this()
    {
        currentHP = hp;
    }
    public Player(int hp, int mp):this(hp)
    {
        currntMP = mp;
    }
}*/