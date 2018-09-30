using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inturoduktion : MonoBehaviour
{
    public int number = 7;

    public int triangleBase = 8;
    //public = syns i unity
    //int = heltal
    //float = decimaltal
    //double = float fast dubblet med siffror
    //bool = ja elr nej
    // char = ett tecken
    //string = massor med tecken
    //public int testInt = 5;
    //public float testFloat = 2.0f;
    //public double testDouble = 6.0d;
    //public bool testBool = true;
    //public char testChar = 'G';
    //public string testString = "årkar inte denna skiten";

    public bool IsChecked;
    public int MyIntValue = 10;
    public int UserValue;
    // Use this for initialization
    void Start()
    {
        Testfunktion();
        Uppgift1();
        Uppgift2();
        Uppgift3();
        Uppgift4();

        if (IsChecked == false)
        {
            Debug.Log("it's not true");
        }
        else
        {
            Debug.Log("LIAR");
        }
    }

    void Testfunktion()
    {
        //Debug.Log("plz kill me()");
    }


    void Uppgift1()
    {
        //Debug.Log(string.Format("Svaret på (963f * 421f) - (175463f / 87f) är {0}",
        //    (963f * 421f) - (175463f / 87f)));
    }
    void Uppgift2()
    {
        //print("programering är svårt");
        //print("men jag försöker mitt bästa");
        //print("fortfarande svårt");
    }

    void Uppgift3()
    {
        //Debug.Log(
        //    string.Format(
        //        "talet {0} upphöjt med 2 blir {1} och kvaderatroten ur {0} blir {2}",
        //        number, Mathf.Pow(number, 2), Mathf.Sqrt(number)));
    }
    //u mom gey
    void Uppgift4()
    {
        Debug.Log(triangleBase * 8 / 2);


    }



    // IF SHE BREATHES, SHES A THOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOT!!!!!!!!!!!!!!!!!!!!
    // Update is called once per frame
    void Update()
    {
        // == lika med
        // != inte lika med
        // <= mindre än eller like med
        // >större eller like med
        // < mindre än
        // > större än
        // && och (and)
        // || eller (or)
        //if (MyIntValue >= 10)
        //{
        //    if (IsChecked == true)
        //    { print("måndag"); }
        //}
        //else if (MyIntValue == 9)
        //{ print("Tisdag"); }
        //else
        //{
        //    print("INTE MÅNDAG!! :D");
        //}
        //if (Input.GetKeyDown(KeyCode.W) == true)
        //{
        //    print("reload");
        //}
        //if (Input.GetKeyDown(KeyCode.Q) == true)
        //{
        //    //0 1 2 3 4 5 6 7 8 9
        //    Random.Range(0, 10);
        //    //0.032f, 10.000
        //    Random.Range(0f, 10f);
        //    print("lean left");
        //}


        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
            {
            
            }

    }
}
