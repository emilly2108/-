using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class FileStreamExercise : MonoBehaviour
{
    private void Awake()
    {
        //// ���Ͽ� ������ ����
        int writeData = 35;

        // 1. ���� ��Ʈ�� ���� (�� ���� ���� ���)
        Stream writeStream = new FileStream("FileStream.dat", FileMode.Create); 

        // 2. int byte �迭�� ��ȯ
        byte[] writeBytes = BitConverter.GetBytes(writeData); 

        // 3. ��ȯ�� byte �迭�� ���� ��Ʈ���� ���� ���Ͽ� ���
        writeStream.Write(writeBytes, 0, writeBytes.Length); 

        //4. ���� ��Ʈ�� �ݱ�
        writeStream.Close();

        //// ���Ϸκ��� ������ �б�
        byte[] readBytes = new byte[8];

        // 1. ���� ��Ʈ�� ���� (���� ���� ���)
        Stream readStream = new FileStream("FileStream.dat", FileMode.Open); 

        // 2. bytes ���̸�ŭ(8����Ʈ) �����͸� �о� bytes�� ����
        readStream.Read(readBytes, e, readBytes.Length);

        //3. Bitconverter�� �̿��Ͽ� bytes�� ��� �ִ� ���� int �������� ��ȯ
        int readData = BitConverter.ToInt32 (readBytes, 0);

        // 4. ���� ��Ʈ�� �ݱ�
        readStream.Close();
*/
/*
using UnityEngine;
using System.IO;
public class BinaryFileStreamExercise : MonoBehaviour
{
    private void Awake()
    {
        // BinaryWriter Ŭ���� �ν��Ͻ��� ������ �� �Ű������� Stream Ŭ������ ������� �ϴ� 
        // FileStream, NetwrokStream�� ���� �Ļ� Ŭ���� �ν��Ͻ� ���
        Stream writeStream = new FileStream("BinaryFileStream.dat", FileMode.Create); 
        BinaryWriter binaryWriter = new BinaryWriter(writeStream);

        // BinaryWriter�� Write() �޼ҵ�� ��� C# ������ ���Ŀ� ���� �����ε�
        binaryWriter.Write(35);
        binaryWriter.Write(12.34f);
        binaryWriter.Write("������ �ȳ��ϼ���. ��ڻ��Դϴ�.");

        // ��� �Ϸ� �� Close()�� ��Ʈ�� �ݱ�
        binaryWriter.Close();

        // BinaryReader �ν��Ͻ��� ������ �� �Ű������� Stream Ŭ������ ������� �ϴ�
        // FileStream, NetwrokStream�� ���� �Ļ� Ŭ���� �ν��Ͻ� ���
        Stream readStream = new FileStream("BinaryFileStream.dat", FileMode.Open); 
        BinaryReader binaryReader = new BinaryReader(readStream);

        // BinaryFileStream.dat
        Debug.Log($"File Size: {readStream.Length} Bytes");

        // BinaryReader�� ReadXX() �޼ҵ�� ���� ������ ���ĺ��� �޼ҵ带 ����
        Debug.Log(binaryReader.ReadInt32()); // int
        Debug.Log(binaryReader.ReadSingle()); // float
        Debug.Log(binaryReader.ReadString()); // string

        // ��� �Ϸ� �� Close()�� ��Ʈ�� �ݱ�
        binaryReader.Close();
    }
}*/

/*using UnityEngine;
using System.IO;
public class TextFileStreamExercise : MonoBehaviour
{
    private void Awake()
    {
        Stream writeStream = new FileStream("TextFileStream.dat", FileMode.Create);
        StreamWriter streamWriter = new StreamWriter(writeStream);

        // StreamWriter�� Write(), WriteLine() �޼ҵ�� ��� C# ������ ���Ŀ� ���� �����ε�
        streamWriter.Write(36);   // ���Ͱ� ���� �Է�
        streamWriter.WriteLine(12.34f);  // ������ ���� ���Ͱ� �ڵ� ����
        streamWriter.WriteLine("������ �ȳ��ϼ���. ��ڻ��Դϴ�.");  
        
        // ��� �Ϸ� �� Close()�� ��Ʈ�� �ݱ�
        streamWriter.Close();

        Stream readStream = new FileStream("TextFileStream.dat", FileMode.Open);
        StreamReader streamReader = new StreamReader(readStream);

        // �� �پ� �о ó���ؾ� �� ���� while �ݺ����� Endofstream ������Ƽ �̿� 
        // ��Ʈ���� ���� �����ߴ��� �˻�
        while (streamReader.EndOfStream == false)
        {
            // ���� Ŀ���� �ִ� ��ġ�� �����͸� ���� �о�´�.
            Debug.Log(streamReader.ReadLine());
        }

        // �Ѳ����� �о ó���ؾ� �� ���� ReadToEnd() �޼ҵ� �̿� 
        // ���� Ŀ���� �ִ� ��ġ���� ������ ������ �����͸� �о�´�. 
        //Debug.Log(streamReader.ReadToEnd());

        // ��� �Ϸ� �� Close()�� ��Ʈ�� �ݱ�
        streamReader.Close();
    }
}*/
/*using UnityEngine;                                  
using System.IO;                                       //FileStream, Stream Class 
using System;                                          // Serializable, NonSerialized 
using System.Runtime.Serialization.Formatters.Binary;  // BinaryFormatter Class


// ����ȭ �� Ŭ����, ����ü �տ� [Serializable] ��Ʈ����Ʈ ����
// ���� Player Ŭ������ ���ǵ� ��� �������� ����ȭ �Ǿ� ���� ���·� ���� ����
[Serializable]
public class Player
{
    public string name;
    public int age;

    // ����ȭ ��󿡼� �����ϰ� ���� ��� ���� �տ� �ۼ�
    // ����ȭ �� �� ���嵵 �ȵǰ�, ������ȭ �� �� �ҷ����⵵ ���� �ʴ´�
    [NonSerialized]
    public string address;
    public Player(string name, int age, string address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }
    public void PrintData()
    {
        Debug.Log($"{name} : ����({age}), �ּ�({address})");
    }
}*/
        