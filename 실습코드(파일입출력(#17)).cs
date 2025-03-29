using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class FileExercise : MonoBehaviour
{
    private void Awake()
    {
        // ���ο� ���� ���� (���/���ϸ��� �Ű������� �Է�)
        FileStream file = File.Create("a.dat");
        // �ڵ忡�� ���� ���� �����͸� �����ϱ� ���� ������ ���� �ݰ� �Ǵµ�
        // ������ �����ϸ� �ڵ����� ������ ������ �ȴ�.
        // �׷��� ������ �ݾ�����(Close) ������
        // Copy(), Move(), Delete()�� ���� ���� �ܺο����� ���� �Ұ���

        // ������ ������ �� FileStream ��ȯ �����͸� �޾Ƽ� Close()�� ������ �ݾ��ش�
        file.Close();

        // ù ��° �Ű������� �Էµ� ������ ����(Ctrl+C)�ؼ� 
        // �� ��° �Ű������� �Էµ� ���Ϸ� �ٿ��ֱ�(Ctrl+V)
        File.Copy("a.dat", "b.dat");

        // ù ��° �Ű������� �Էµ� ������ �߶󳻱�(Ctrl+X)�ؼ� 
        // �� ��° �Ű������� �Էµ� ���Ϸ� �ٿ��ֱ�(Ctrl+V)
        File.Move("a.dat", "c.dat");

        // �Ű������� �Էµ� ������ �ִ��� �˻�
        bool isExists = File.Exists("c.dat"); 
        Debug.Log($"c.dat ���� ���� ����: {isExists}");

        // �Ű������� �Էµ� ������ �Ӽ�
        FileAttributes attr = file GetAttributes("c.dat");
        Debug.Log($"c.dat ���ϼӼ� : {attr}");

        //�Ű������� �Էµ� ���� ����
        file.Delete("c.dat");
        file.Delete("b.dat");
    }
}*/
/*using UnityEngine;
using System.IO;
public class FileInfoExercise : MonoBehaviour
{
    private void Awake()
    {
        // FileInfo Class �ν��Ͻ� ���� ����
        // �޸𸮸� �Ҵ��� �� ������ �Ű������� ����� ������ ���/���ϸ��� ���ڿ��� �ۼ�
        FileInfo fileInfo = new FileInfo("d.dat");
        // ���ο� ���� ����
        FileStream file = fileInfo.Create();

        // �ڵ忡�� ���� ���� �����͸� �����ϱ� ���� ������ ���� �ݰ� �Ǵµ�
        // ������ �����ϸ� �ڵ����� ������ ������ �ȴ�.
        // �׷��� ������ �ݾ�����(Close) ������
        // CopyTo(), MoveTo(), Delete()�� ���� ���� �ܺο����� ���� �Ұ���

        // ������ ������ �� FileStream ��ȯ �����͸� �޾Ƽ� Close()�� ������ �ݾ��ش�
        file.Close();

        // ������ ����(Ctrl+C)�ؼ� �Ű������� �Էµ� ���Ϸ� �ٿ��ֱ�(Ctrl+V)
        fileInfo.CopyTo("e.dat");
        // ������ �߶󳻱�(Ctrl+X)�ؼ� �Ű������� �Էµ� ���Ϸ� �ٿ��ֱ�(Ctrl+V) 
        // �ش� ��ġ�� ������ ���ϸ��� �����ϸ� ���� �߻�
        fileInfo.MoveTo("f.dat");

        // ������ �ִ��� �˻�
        bool isExists = fileInfo.Exists;
        Debug.Log($"{fileInfo.Name} ���� ���� ���� : {isExists}");

        // ������ �Ӽ�
        FileAttributesattr = fileInfo.Attributes;
        Debug.Log($"{fileInfo.Name} ���� �Ӽ�: {attr}");

        // ���� ����

        fileInfo.Delete();
    }
}*/

/*{
    private void Awake()
    {
        // �Ű������� �Էµ� ���/���������� �� ���� ����
        Directory.CreateDirectory("Exercise");

        // ù ��° �Ű����� ������ �߶󳻱��ؼ� �� ��° �Ű����� ���������� �ٿ��ֱ�
        Directory.Move("Exercise", "Exercise2");

        // �Ű������� �Էµ� ������ ���� ���� Ȯ��
        bool isExists = Directory.Exists("Exercise2");
        Debug.Log($"Exercise2 ���� ���� ����: {isExists}");

        // �Ű������� �Էµ� ������ ������ �ִ� ��� ���� ����
        string[] directorys  = Directory.GetDirectories("Exercise2");
        Debug.Log($"���� ���� ����: {directorys.Length}");

        // �Ű������� �Էµ� ������ ������ �ִ� ��� ���� ����
        string[] files = Directory.GetFiles("Exercise2");
        Debug.Log($"���� ���� ����: {files.Length}");

        // ù ��° �Ű������� �Էµ� ���� ����
        // �� ��° �Ű������� true�̸� ���� ���� ��� ���� (���� ������ ������ �����ؾ� ��)
        Directory.Delete("Exercised");
    }
}
*/
