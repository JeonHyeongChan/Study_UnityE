using System;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public int a;
    public int b;
    public string message;
    public string fruit;
    public int[] arr2 = new int[3];
    public List<string> stringList = new List<string>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (a > b)
        {
            Debug.Log("a가 b보다 큽니다.");
        }
        else if (a < b)
        {
            Debug.Log("a가 b보다 크지 않습니다.");
        }
        else
        {
            Debug.Log("a와 b는 같습니다.");
        }

        switch (this.fruit)
        {
            case "사과":
                Debug.Log("사과는 빨갛습니다.");
                break;

            case "바나나":
                Debug.Log("바나나는 노랗습니다.");
                break;

            case "포도":
                Debug.Log("포도는 보라색입니다.");
                break;

            default:
                Debug.Log("알 수 없는 과일입니다.");
                break;
        }
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("i 의 값: " + i);
        }

        while (a < 10)
        {
            Debug.Log("a의 값: " + a);
            a++;
        }
        do
        {
            Debug.Log("b의 값: " + b);
            b--;
        } while (b > 0);

        
        string[] array = new string[6];
        array[0] = "강대원";
        array[1] = "민영희";
        array[2] = "박두팔";
        array[3] = "안선생";
        array[4] = "함수빈";
        array[5] = "최종훈";
     

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("학생 이름: " + array[i]);
        }

        int[] scores = { 90, 85, 78, 92, 88 };

        for (int j = 0; j < arr2.Length; j++)
        {
            Debug.Log("점수: " + scores[j]);
        }

        string[,] zoo = new string[3,3];
        zoo[0,0] = "사자";
        zoo[0,1] = "호랑이";
        zoo[0,2] = "곰";
        zoo[1,0] = "코끼리";
        zoo[1,1] = "기린";
        zoo[1,2] = "얼룩말";
        zoo[2,0] = "펭귄";
        zoo[2,1] = "바다사자";
        zoo[2,2] = "물개";
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                Debug.Log("동물원 동물: " + zoo[x,y]);
            }
        }

        int[,] samsam = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; 

        List<string> studentList = new List<string>();

        studentList.Add("강대원");
        studentList.Add("민영희");
        studentList.Add(null);
        studentList.Add("안선생");
        studentList.Add("함수빈");
        Debug.Log(studentList[2]);
        studentList.RemoveAt(2);
        Debug.Log(studentList[2]);
        foreach (string student in studentList)
        {
            Debug.Log("학생 이름: " + student);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
