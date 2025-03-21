using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Player : MonoBehaviour
//멤버 함수
{
    private string ID = " 고박사";
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
//접근 지정자 예시
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
//클래스 객체 생성
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
//생성자(new로 메모리 할당할 때)
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
    // 생성자 메소드 오버로딩
{
    public string ID;
    private int currentHP;
    
    public Player()
    {
        ID = "고박사";
        currentHP = 1000;
    }

    public Player(string id, int hp)
    {
        ID = id;
        currentHP = hp;
    }
}*/

 /*public class Player
    //this 생성자
{
    private string ID;
    private int currentHP;
    private int currntMP;           

    public Player()
    {
        ID = "고박사";
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