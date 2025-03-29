using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class ArrayListExercise : MonoBehaviour
{
    private void Awake()
    {
        //�÷��� �ڷᱸ���� ������ ������ new�� �޸𸮸� �Ҵ��ؾ� ����� �� �ִ�.
        ArrayList arrayList = new ArrayList();

        //����߰� ( ����)
        //object Ÿ���̱� ������ ���� ������ ������ ���� ����
        Debug.Log(arrayList.Add(10));
        //Debug.Log(arrayList.Add(12.3f));
        //Debug.Log(arrayList.Add("�ȳ��ϼ���. ��ڻ��Դϴ�."));

        //������ ���
        PrintArrayList(arrayList);

        //��� �߰�(���ϴ� ��ġ)
        arrayList.Insert(1, 100);

        //��� �߰� (����, ICollection)
        Collection<int> data = new Collection<int>();
        data.Add(1);
        data.Add(3);
        data.Add(2);
        arrayList.AddRange(data);

        //������ ���
        PrintArrayList(arrayList);

        // ������ ���� (ArrayList�� ���� �����Ϳ��� ���� �� �������� ��밡��)
        // �� �� �����Ͱ� ������� ��� ���� �߻�
        arrayList.Sort();

        //���������
        PrintArrayList(arrayList);

        //��� ���� (�Ű������� �Էµ� ������)
        arrayList.Remove(10);

        //������ ���
        PrintArrayList(arrayList);

        //��� ���� (�Ű������� �Էµ� ��ġ�� ���)
        arrayList.RemoveAt(0);

        //������ ���
        PrintArrayList(arrayList);

        //��� ���� (ù ��° �Ű����� ��ġ���� �ι�° �Ű����� ������ŭ ����)
        arrayList.RemoveRange(0, 2);

        //������ ���
        PrintArrayList(arrayList);

        //����� ����
        arrayList.Clear();

        //��Ұ������
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
        // �÷��� �ڷᱸ���� ������ ������ new�� �޸𸮸� �Ҵ��ؾ� ����� �� �ִ�.
        Queue queue = new Queue();

        // �Ĵܿ� ���ο� ��� �߰�
        for (int i = 0; i < 5; ++i)
        {
            queue.Enqueue(i);
        }

        // ���� ť�� ����� ����� ����
        Debug.Log($"Queue Count: {queue.Count}");

        // ���ܿ� �ִ� ��Ҹ� �������� �ʰ�, ��Ҹ� ��ȯ�� �� ���
        Debug.Log($"���� 0�� ���: {queue.Peek()}");

        Debug.Log($"Queue Count: {queue.Count}");

        // ���ܿ� �ִ� ��Ҹ� �����ϰ�, ������ ��Ҹ� ��ȯ
        object data = queue.Dequeue();
        Debug.Log($"ť���� �������� ������: {data}");

        Debug.Log($"Queue Count: {queue.Count}");

        // ť�� ��� ��� ����
        queue.Clear();

        Debug.Log($"Queue Count : {Queue.Count}");
    }
}*/

/*public class StackExercise : MonoBehaviour
{
    private void Awake()
    {
        // �÷��� �ڷᱸ���� ������ ������ new�� �޸𸮸� �Ҵ��ؾ� ����� �� �ִ�.
        Stack stack = new Stack();

        // ������ �ֻ����� ���ο� ��� �߰�
        for (int i = 0; i < 5; ++i)
        {
            stack.Push(i);
        }
        // ���� ���ÿ� ����� ����� ����
        Debug.Log($"Stack Count: {stack.Count}");

        // ������ �ֻ��� ��Ҹ� �������� �ʰ�, ��Ҹ� ��ȯ�� �� ���
        Debug.Log($"�������� �߰��� ���: {stack.Peek()}");
        Debug.Log($"Stack Count: {stack.Count}");

        // ������ �ֻ��� ��Ҹ� �����ϰ�, ������ ��Ҹ� ��ȯ
        object data = stack.Pop();
        Debug.Log($"���ÿ��� �������� ������ : {data}");

        Debug.Log($"Stack Count: {stack.Count}");

        // ������ ��� ��� ����
        Stack.Clear();

        Debug.Log($"Stack Count : {Stack.Count}");
    }
}*/

public class HashtableExercise : MonoBehaviour
{
    private void Awake()
    {
        // �÷��� �ڷᱸ���� ������ ������ new�� �޸𸮸� �Ҵ��ؾ� ����� �� �ִ�.
        Hashtable hash = new Hashtable();

        // �÷��� �ڷᱸ���� object Ÿ���� �����ϱ� ������ Ŭ���� �ν��Ͻ��� ���� ����
        Goblin goblin = new Goblin();
        Slime slime = new Slime();

        // ��� �߰� ( [] ������)
        hash["Goblin"] = goblin;

        // ��� �߰� (Add �޼ҵ�)
        hash.Add("Slime", slime);
        hash.Add(1, "����");
        hash.Add(1.2f, "�Ǽ�");
        hash.Add("�ȳ��ϼ���. ��ڻ��Դϴ�.", "���ڿ�");

        // Hashtable, Dictionary ��� ���� ������ for���� Ȱ���� 
        // ���������� ������ Ž���� �Ұ����� �� ����ϴ� �ݺ��� 
        // foreach (������Ÿ�� ������ in �迭 �� ������ ����)
        foreach (object key in hash.Keys)
        {
            Debug.Log($"hash[{key}] = {hash[key]}");
        }
        // �ؽ����̺� "Slime" Ű�� ������ ��Ұ� �ִ��� Ž��
        if (hash.ContainsKey("Slime"))
        {
            Debug.Log($"Slime Ű ����");
        }

        // �ؽ����̺� goblin ���� ������ ��Ұ� �ִ��� Ž��
        if (hash.ContainsValue(goblin))
        {
            Debug.Log($"{goblin} �� ����");
        }

        // ���� �ؽ����̺� ����� ����� ����
        Debug.Log($"Hashtable Count: {hash.Count}");

        // �ؽ����̺��� �Ű������� �Էµ� "Slime"�� Ű�� ������ ��� ����
        hash.Remove("Slime");

        // ���� �ؽ����̺� ����� ����� ����
        Debug.Log($"Hashtable Count: {hash.Count}");

        // �ؽ����̺��� ��� ��� ����
        hash.Clear();
        // ���� �ؽ����̺� ����� ����� ����
        Debug.Log($"Hashtable Count: {hash.Count}");
    }
}

public class Goblin { }
public class Slime{ }