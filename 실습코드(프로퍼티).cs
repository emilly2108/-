using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Player
//멤버 변수의 은닉성보단 편리성 선택
{
    public int currentHP;
}
public class GameController
{
    private void Awake()
    {
        Player player = new Player();
        player.currentHP = 100;
        Debug.Log($"player HP : {player.currentHP}");
    }
}*/
/*public class Player
//get(),set()멤버 함수
{
    // 멤버 변수를 private으로 은닉하고, Get()/Set() 메서드 작성
    private int currentHP;

    public int GetCurrentHP() { return currentHP; }
    public void SetCurrentHP(int hp) { currentHP = hp; }
}

public class GameController
{
    private void Awake()
    {
        Player player = new Player();
        player.SetCurrentHP(100);
        Debug.Log($"Player HP : {player.GetCurrentHP()}");
    }
}*/
// 읽기 전용 프로퍼티
/*public class Player
{
    private int currentHP;

    public int CurrentHP
    {
        get => currentHP;
    }
}
*/
// 쓰기 전용 프로퍼티
/*public class Player
{
    private int currentHP;

    public int CurrentHP
    {
        set => currentHP = value;
    }
}*/
//private 접근자
/*public class Player
{
    private int currentHP;

    public int CurrentHP
    {
        private set => currentHP = value;
        get => currentHP;
    }
}*/
//추상클래스의 프로퍼티 예시
/*public abstract class BaseEntity
{
    abstract public int Shield { get; set; }

    public int Defense { get; set; }
}*/

/*public class Player : BaseEntity
{
    public override int Shield { get; set; }
    public int ID { get; set; }
}*/
