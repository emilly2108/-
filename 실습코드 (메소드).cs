using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Calculator
 //메소드 예
{
    public int Add(int num1, int num2)
    
    {
        int result = num1 + num2;
        return result;
    }

    public void Multiple(int num1, int num2)
    {
        int result = num1 * num2;
        Debug.Log($"{num1} x {num2} = { result}");
    
        
    }
}*/
/*public class Calculator
 //메소드 장점- 동일 코드 반복 작성 필요x
{
    private void Awake()
    {
        Multiple(3, 4);
        Multiple(5, 8);
        Multiple(4, 6);

    }

    public void Multiple(int num1, int num2)
    {
        int result = num1 * num2;
        Debug.Log($"{num1} x {num2} = { result}");
    }
}*/

/*public class Calculator
 //return 반환
{
    private void Awake()
    {
        int a = Max(10, 20);
        Debug.Log(Max(100, 200));
        Max(5, 10);
    }

    public int Max(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        return num2;
    }
}*/

/*public class Calculator
 //매개 변수
{
    public void Divide(int num1, int num2)
    {
        if (num2 == 0)
        {
            Debug.Log("나누려는 값이 0이기 때문에 프로그램 종료");
            return;
        }

        float result = num1 / num2;
        Debug.Log($"{num1} x {num2} = { result}");

    }
}*/
/*public class Calculator
//값에 의한 전달과 참조에 의한 전달
{
    private void Awake()
    {
        int a = 3, b = 4;
        Add (a, b);
        Add(10, 20);
    }

    public void Add(int num1, int num2)
    {
        int result = num1 + num2;
        Debug.Log($"{num1} x {num2} = { result}");
    }
}*/
/*public class Calculator
//출력 전용 매개변수
{
    private void Awake()
    {
        int a = 3, b = 4;
        Debug.Log($"a={a}, b={b}");
        Swap(ref a, ref b);
        Debug.Log($"a={a}, b={b}");
    }

    public void Swap(ref int num1, ref int num2)
    {
        int temp = num1 ;
        num1 = num2;
        num2 = temp;
    }
}*/
/*public class Calculator
//메소드 오버로딩(정수)
{
    public void Addlnt(int num1, int num2)
    {
        int result = num1 + num2;
        Debug.Log($"{num1} + {num2} = { result}");
    }
}*/

/*public class Calculator
//메소드 오버로딩(실수)
{
    public void Addlnt(float num1, float num2)
    {
        float result = num1 + num2;
        Debug.Log($"{num1} + {num2} = { result}");
    }
}*/

/*public class Calculator
 //가변 길이 매개 변수
{
    public void Sum(params int[] nums)
    {
        int sum = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            sum += nums[i];
        }
        Debug.Log($"합계 : {sum}");
    }
}*/