using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestConstruct : MonoBehaviour
{
    anotherClass myClassVar;

    private void Start()
    {
        myClassVar = new anotherClass();

        myClassVar.x = myClassVar.return4(50);


        myClassVar = null;

    }
}


public class anotherClass
{
    public int x = 0;

    public anotherClass()
    {
        x = 4;
        Debug.Log("HEY HEY ");
    }

    ~anotherClass()
    {
        Debug.Log("this is dead ");
    }

    public anotherClass(int test)
    {
        x = test;
    }

    public  int return4()
    {
        return 4;
    }

    public  int return4(int y)
    {
        return y;
    }
}