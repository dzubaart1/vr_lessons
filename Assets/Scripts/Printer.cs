using System;
using UnityEngine;

public class Printer : MonoBehaviour
{
    //Типы данных:
    //int - 0,1,2,3,4,5,6,7,8
    //string - "Hello world!"
    //float - 0.1f, 0.4f, 0.06f, 1f(1.0f), 10f(10.0f), 

    public string fullName = "Дзюба Артур Денисович";
    
    private void Start()
    {
        Debug.Log(fullName + " классный препод!");
        Debug.Log(fullName);
        Debug.Log("Hello World!");
    }

    private void Update()
    {
        /*Debug.Log("Дзюба Артур");
        Debug.Log("Zoom156");
        Debug.Log("Krotkov Nikita");
        Debug.Log("Ksenia Virolainen");
        Debug.Log("NataliaM");*/
    }
}
