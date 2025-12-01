using UnityEngine;


public class Study: MonoBehaviour
{ //public 전역
  //private 지역
    public string say = "";
    private string said = "";
    string saying = "Hey";
    public char text;
    //public number ㅋㅋ
    public int a = 1;
    public long aa = 11;
    public double b = 0.1;
    public float c = 0.3f;
    public bool d = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(say);
        Debug.Log(said);
        Debug.Log(saying);

        int a = 10;
        Debug.Log(a++);
        Debug.Log(++a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
