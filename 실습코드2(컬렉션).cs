using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class ArrayListExercise : MonoBehaviour
{
    private void Awake()
    {
        //컬렉션 자료구조는 선언한 변수에 new로 메모리를 할당해야 사용할 수 있다.
        ArrayList arrayList = new ArrayList();

        //요소추가 ( 순차)
        //object 타입이기 때문에 여러 종류의 데이터 저장 가능
        Debug.Log(arrayList.Add(10));
        //Debug.Log(arrayList.Add(12.3f));
        //Debug.Log(arrayList.Add("안녕하세요. 고박사입니다."));

        //데이터 출력
        PrintArrayList(arrayList);

        //요소 추가(원하는 위치)
        arrayList.Insert(1, 100);

        //요소 추가 (범위, ICollection)
        Collection<int> data = new Collection<int>();
        data.Add(1);
        data.Add(3);
        data.Add(2);
        arrayList.AddRange(data);

        //데이터 출력
        PrintArrayList(arrayList);

        // 데이터 정렬 (ArrayList에 정수 데이터에만 있을 때 한정으로 사용가능)
        // 그 외 데이터가 들어있을 경우 에러 발생
        arrayList.Sort();

        //데이터출력
        PrintArrayList(arrayList);

        //요소 삭제 (매개변수에 입력된 데이터)
        arrayList.Remove(10);

        //데이터 출력
        PrintArrayList(arrayList);

        //요소 삭제 (매개변수에 입력된 위치의 요소)
        arrayList.RemoveAt(0);

        //데이터 출력
        PrintArrayList(arrayList);

        //요소 삭제 (첫 번째 매개변수 위치부터 두번째 매개변수 개수만큼 삭제)
        arrayList.RemoveRange(0, 2);

        //데이터 출력
        PrintArrayList(arrayList);

        //모든요소 삭제
        arrayList.Clear();

        //요소개수출력
        Debug.Log(arrayList.Count);
    }

    public void PrintArrayList(ArrayList list)
    {
        Debug.Log("============================");

        for (int i = 0; i < list.Count; ++ i )
        {
            Debug.Log($"list[{i}] = {list[i]}");
        }
    }
}*/

/*public class Queue Exercise: MonoBehaviour
{
    private void Awake()
    {
        // 컬렉션 자료구조는 선언한 변수에 new로 메모리를 할당해야 사용할 수 있다.
        Queue queue = new Queue();

        // 후단에 새로운 요소 추가
        for (int i = 0; i < 5; ++i)
        {
            queue.Enqueue(i);
        }

        // 현재 큐에 저장된 요소의 개수
        Debug.Log($"Queue Count: {queue.Count}");

        // 전단에 있는 요소를 삭제하지 않고, 요소를 반환할 때 사용
        Debug.Log($"현재 0번 요소: {queue.Peek()}");

        Debug.Log($"Queue Count: {queue.Count}");

        // 전단에 있는 요소를 삭제하고, 삭제한 요소를 반환
        object data = queue.Dequeue();
        Debug.Log($"큐에서 빠져나온 데이터: {data}");

        Debug.Log($"Queue Count: {queue.Count}");

        // 큐의 모든 요소 삭제
        queue.Clear();

        Debug.Log($"Queue Count : {Queue.Count}");
    }
}*/

/*public class StackExercise : MonoBehaviour
{
    private void Awake()
    {
        // 컬렉션 자료구조는 선언한 변수에 new로 메모리를 할당해야 사용할 수 있다.
        Stack stack = new Stack();

        // 스택의 최상위에 새로운 요소 추가
        for (int i = 0; i < 5; ++i)
        {
            stack.Push(i);
        }
        // 현재 스택에 저장된 요소의 개수
        Debug.Log($"Stack Count: {stack.Count}");

        // 스택의 최상위 요소를 삭제하지 않고, 요소를 반환할 때 사용
        Debug.Log($"마지막에 추가된 요소: {stack.Peek()}");
        Debug.Log($"Stack Count: {stack.Count}");

        // 스택의 최상위 요소를 삭제하고, 삭제한 요소를 반환
        object data = stack.Pop();
        Debug.Log($"스택에서 빠져나온 데이터 : {data}");

        Debug.Log($"Stack Count: {stack.Count}");

        // 스택의 모든 요소 삭제
        Stack.Clear();

        Debug.Log($"Stack Count : {Stack.Count}");
    }
}*/

public class HashtableExercise : MonoBehaviour
{
    private void Awake()
    {
        // 컬렉션 자료구조는 선언한 변수에 new로 메모리를 할당해야 사용할 수 있다.
        Hashtable hash = new Hashtable();

        // 컬렉션 자료구조는 object 타입을 저장하기 때문에 클래스 인스턴스도 저장 가능
        Goblin goblin = new Goblin();
        Slime slime = new Slime();

        // 요소 추가 ( [] 연산자)
        hash["Goblin"] = goblin;

        // 요소 추가 (Add 메소드)
        hash.Add("Slime", slime);
        hash.Add(1, "정수");
        hash.Add(1.2f, "실수");
        hash.Add("안녕하세요. 고박사입니다.", "문자열");

        // Hashtable, Dictionary 등과 같이 기존의 for문을 활용해 
        // 순차적으로 데이터 탐색이 불가능할 때 사용하는 반복문 
        // foreach (데이터타입 변수명 in 배열 등 데이터 집합)
        foreach (object key in hash.Keys)
        {
            Debug.Log($"hash[{key}] = {hash[key]}");
        }
        // 해시테이블에 "Slime" 키를 가지는 요소가 있는지 탐색
        if (hash.ContainsKey("Slime"))
        {
            Debug.Log($"Slime 키 존재");
        }

        // 해시테이블에 goblin 값을 가지는 요소가 있는지 탐색
        if (hash.ContainsValue(goblin))
        {
            Debug.Log($"{goblin} 값 존재");
        }

        // 현재 해시테이블에 저장된 요소의 개수
        Debug.Log($"Hashtable Count: {hash.Count}");

        // 해시테이블에서 매개변수에 입력된 "Slime"을 키로 가지는 요소 삭제
        hash.Remove("Slime");

        // 현재 해시테이블에 저장된 요소의 개수
        Debug.Log($"Hashtable Count: {hash.Count}");

        // 해시테이블의 모든 요소 삭제
        hash.Clear();
        // 현재 해시테이블에 저장된 요소의 개수
        Debug.Log($"Hashtable Count: {hash.Count}");
    }
}

public class Goblin { }
public class Slime{ }