using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Player
//��� ������ ���м����� ���� ����
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
//get(),set()��� �Լ�
{
    // ��� ������ private���� �����ϰ�, Get()/Set() �޼��� �ۼ�
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
// �б� ���� ������Ƽ
/*public class Player
{
    private int currentHP;

    public int CurrentHP
    {
        get => currentHP;
    }
}
*/
// ���� ���� ������Ƽ
/*public class Player
{
    private int currentHP;

    public int CurrentHP
    {
        set => currentHP = value;
    }
}*/
//private ������
/*public class Player
{
    private int currentHP;

    public int CurrentHP
    {
        private set => currentHP = value;
        get => currentHP;
    }
}*/
//�߻�Ŭ������ ������Ƽ ����
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
