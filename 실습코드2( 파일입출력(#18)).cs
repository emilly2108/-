using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class FileStreamExercise : MonoBehaviour
{
    private void Awake()
    {
        //// 파일에 데이터 쓰기
        int writeData = 35;

        // 1. 파일 스트림 생성 (새 파일 생성 모드)
        Stream writeStream = new FileStream("FileStream.dat", FileMode.Create); 

        // 2. int byte 배열로 변환
        byte[] writeBytes = BitConverter.GetBytes(writeData); 

        // 3. 변환한 byte 배열을 파일 스트림을 통해 파일에 기록
        writeStream.Write(writeBytes, 0, writeBytes.Length); 

        //4. 파일 스트림 닫기
        writeStream.Close();

        //// 파일로부터 데이터 읽기
        byte[] readBytes = new byte[8];

        // 1. 파일 스트림 생성 (파일 열기 모드)
        Stream readStream = new FileStream("FileStream.dat", FileMode.Open); 

        // 2. bytes 길이만큼(8바이트) 데이터를 읽어 bytes에 저장
        readStream.Read(readBytes, e, readBytes.Length);

        //3. Bitconverter를 이용하여 bytes에 담겨 있는 값을 int 형식으로 변환
        int readData = BitConverter.ToInt32 (readBytes, 0);

        // 4. 파일 스트림 닫기
        readStream.Close();
*/
/*
using UnityEngine;
using System.IO;
public class BinaryFileStreamExercise : MonoBehaviour
{
    private void Awake()
    {
        // BinaryWriter 클래스 인스턴스를 생성할 때 매개변수로 Stream 클래스를 기반으로 하는 
        // FileStream, NetwrokStream과 같은 파생 클래스 인스턴스 사용
        Stream writeStream = new FileStream("BinaryFileStream.dat", FileMode.Create); 
        BinaryWriter binaryWriter = new BinaryWriter(writeStream);

        // BinaryWriter의 Write() 메소드는 모든 C# 데이터 형식에 대해 오버로딩
        binaryWriter.Write(35);
        binaryWriter.Write(12.34f);
        binaryWriter.Write("여러분 안녕하세요. 고박사입니다.");

        // 사용 완료 후 Close()로 스트림 닫기
        binaryWriter.Close();

        // BinaryReader 인스턴스를 생성할 때 매개변수로 Stream 클래스를 기반으로 하는
        // FileStream, NetwrokStream과 같은 파생 클래스 인스턴스 사용
        Stream readStream = new FileStream("BinaryFileStream.dat", FileMode.Open); 
        BinaryReader binaryReader = new BinaryReader(readStream);

        // BinaryFileStream.dat
        Debug.Log($"File Size: {readStream.Length} Bytes");

        // BinaryReader의 ReadXX() 메소드는 읽을 데이터 형식별로 메소드를 제공
        Debug.Log(binaryReader.ReadInt32()); // int
        Debug.Log(binaryReader.ReadSingle()); // float
        Debug.Log(binaryReader.ReadString()); // string

        // 사용 완료 후 Close()로 스트림 닫기
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

        // StreamWriter의 Write(), WriteLine() 메소드는 모든 C# 데이터 형식에 대해 오버로딩
        streamWriter.Write(36);   // 엔터가 없는 입력
        streamWriter.WriteLine(12.34f);  // 내용의 끝에 엔터가 자동 삽입
        streamWriter.WriteLine("여러분 안녕하세요. 고박사입니다.");  
        
        // 사용 완료 후 Close()로 스트림 닫기
        streamWriter.Close();

        Stream readStream = new FileStream("TextFileStream.dat", FileMode.Open);
        StreamReader streamReader = new StreamReader(readStream);

        // 한 줄씩 읽어서 처리해야 할 때는 while 반복문과 Endofstream 프로퍼티 이용 
        // 스트림의 끝에 도달했는지 검사
        while (streamReader.EndOfStream == false)
        {
            // 현재 커서가 있는 위치의 데이터를 한줄 읽어온다.
            Debug.Log(streamReader.ReadLine());
        }

        // 한꺼번에 읽어서 처리해야 할 때는 ReadToEnd() 메소드 이용 
        // 현재 커서가 있는 위치부터 파일의 끝까지 데이터를 읽어온다. 
        //Debug.Log(streamReader.ReadToEnd());

        // 사용 완료 후 Close()로 스트림 닫기
        streamReader.Close();
    }
}*/
/*using UnityEngine;                                  
using System.IO;                                       //FileStream, Stream Class 
using System;                                          // Serializable, NonSerialized 
using System.Runtime.Serialization.Formatters.Binary;  // BinaryFormatter Class


// 직렬화 할 클래스, 구조체 앞에 [Serializable] 어트리뷰트 정의
// 이제 Player 클래스에 정의된 멤버 변수들은 직렬화 되어 파일 형태로 저장 가능
[Serializable]
public class Player
{
    public string name;
    public int age;

    // 직렬화 대상에서 제외하고 싶은 멤버 변수 앞에 작성
    // 직렬화 할 때 저장도 안되고, 역직렬화 할 때 불러오기도 되지 않는다
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
        Debug.Log($"{name} : 나이({age}), 주소({address})");
    }
}*/
        