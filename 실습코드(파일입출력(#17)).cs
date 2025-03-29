using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class FileExercise : MonoBehaviour
{
    private void Awake()
    {
        // 새로운 파일 생성 (경로/파일명은 매개변수에 입력)
        FileStream file = File.Create("a.dat");
        // 코드에서 파일 내부 데이터를 수정하기 위해 파일을 열고 닫게 되는데
        // 파일을 생성하면 자동으로 파일이 열리게 된다.
        // 그래서 파일을 닫아주지(Close) 않으면
        // Copy(), Move(), Delete()와 같이 파일 외부에서의 제어 불가능

        // 파일을 생성할 때 FileStream 반환 데이터를 받아서 Close()로 파일을 닫아준다
        file.Close();

        // 첫 번째 매개변수에 입력된 파일을 복사(Ctrl+C)해서 
        // 두 번째 매개변수에 입력된 파일로 붙여넣기(Ctrl+V)
        File.Copy("a.dat", "b.dat");

        // 첫 번째 매개변수에 입력된 파일을 잘라내기(Ctrl+X)해서 
        // 두 번째 매개변수에 입력된 파일로 붙여넣기(Ctrl+V)
        File.Move("a.dat", "c.dat");

        // 매개변수에 입력된 파일이 있는지 검사
        bool isExists = File.Exists("c.dat"); 
        Debug.Log($"c.dat 파일 존재 여부: {isExists}");

        // 매개변수에 입력된 파일의 속성
        FileAttributes attr = file GetAttributes("c.dat");
        Debug.Log($"c.dat 파일속성 : {attr}");

        //매개변수에 입력된 파일 삭제
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
        // FileInfo Class 인스턴스 변수 생성
        // 메모리를 할당할 때 생성자 매개변수에 사용할 파일의 경로/파일명을 문자열로 작성
        FileInfo fileInfo = new FileInfo("d.dat");
        // 새로운 파일 생성
        FileStream file = fileInfo.Create();

        // 코드에서 파일 내부 데이터를 수정하기 위해 파일을 열고 닫게 되는데
        // 파일을 생성하면 자동으로 파일이 열리게 된다.
        // 그래서 파일을 닫아주지(Close) 않으면
        // CopyTo(), MoveTo(), Delete()와 같이 파일 외부에서의 제어 불가능

        // 파일을 생성할 때 FileStream 반환 데이터를 받아서 Close()로 파일을 닫아준다
        file.Close();

        // 파일을 복사(Ctrl+C)해서 매개변수에 입력된 파일로 붙여넣기(Ctrl+V)
        fileInfo.CopyTo("e.dat");
        // 파일을 잘라내기(Ctrl+X)해서 매개변수에 입력된 파일로 붙여넣기(Ctrl+V) 
        // 해당 위치에 동일한 파일명이 존재하면 에러 발생
        fileInfo.MoveTo("f.dat");

        // 파일이 있는지 검사
        bool isExists = fileInfo.Exists;
        Debug.Log($"{fileInfo.Name} 파일 존재 여부 : {isExists}");

        // 파일의 속성
        FileAttributesattr = fileInfo.Attributes;
        Debug.Log($"{fileInfo.Name} 파일 속성: {attr}");

        // 파일 삭제

        fileInfo.Delete();
    }
}*/

/*{
    private void Awake()
    {
        // 매개변수에 입력된 경로/폴더명으로 새 폴더 생성
        Directory.CreateDirectory("Exercise");

        // 첫 번째 매개변수 폴더를 잘라내기해서 두 번째 매개변수 폴더명으로 붙여넣기
        Directory.Move("Exercise", "Exercise2");

        // 매개변수에 입력된 폴더의 존재 여부 확인
        bool isExists = Directory.Exists("Exercise2");
        Debug.Log($"Exercise2 폴더 존재 여부: {isExists}");

        // 매개변수에 입력된 폴더의 하위에 있는 모든 폴더 정보
        string[] directorys  = Directory.GetDirectories("Exercise2");
        Debug.Log($"하위 폴더 개수: {directorys.Length}");

        // 매개변수에 입력된 폴더의 하위에 있는 모든 파일 정보
        string[] files = Directory.GetFiles("Exercise2");
        Debug.Log($"하위 파일 개수: {files.Length}");

        // 첫 번째 매개변수에 입력된 폴더 삭제
        // 두 번째 매개변수가 true이면 하위 폴더 모두 삭제 (하위 파일은 별도로 삭제해야 함)
        Directory.Delete("Exercised");
    }
}
*/
