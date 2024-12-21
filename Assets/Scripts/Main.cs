using JetBrains.Annotations;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //Тип bool
    //Логиечские операторы (==, !, !=, <, >, <=, >=)
    //Ссылочные и несылочные типы данных
    //i++, ++i
    //Объявление и инициализация
    //Ошибка: выход за границы массива
    //Массивы
    //for, foreach, while

    void Start()
    {
        /*int temp = 4;
        bool temp2 = false;

        if (4 > 5)
        {
            Debug.Log("It's 4!");
        }
        else
        {
            Debug.Log("It's not 4!");
        }*/

        /*
         Temp obj1 = new Temp("Arthur");
        Temp obj2 = new Temp("Arthur");*/

        /*int i = 0;

        Debug.Log("Первая попытка:" + (i++));
        Debug.Log("Первая попытка конец: " + i);

        i = 0;

        Debug.Log("Вторая попытка:" + (++i));
        Debug.Log("Втоаря попытка конец: " + i);*/


        /*for (int i = 0; i < 5; i++)
        {
            Debug.Log("Цикл: " + i);
        }

        Debug.Log("Вышли из цикла");*/


        int arrayElementsCount = 5;
        int[] tempArray = new int[arrayElementsCount];

        tempArray[0] = 1;
        tempArray[1] = 3;
        tempArray[2] = 5;
        tempArray[3] = 7;
        tempArray[4] = 9;

        /*int j = arrayElementsCount-1;
        while (j >= 0)
        {
            Debug.Log($"{j} элемент: {tempArray[j]}");
            j--;
        }*/

        /*for (int i = 0; i < arrayElementsCount; i++)
        {
            tempArray[i] = i * 2 + 1;
        }

        for (int i = 0; i < arrayElementsCount; i++)
        {
            Debug.Log($"{i} элемент: {tempArray[i]}");
        }

        int j = 0;
        foreach (int element in tempArray)
        {
            Debug.Log($"{j} элемент: {element}");
            j++;
        }*/

        //Debug.Log("Первый элемент " + tempArray[0]);
        //Debug.Log("Второй элемент " + tempArray[1]);
        //Debug.Log("Третий элемент " + tempArray[2]);
        //Debug.Log("Четвертый элемент " + tempArray[3]);
        //Debug.Log("Пятый элемент " + tempArray[4]);
    }
}

/*public class Temp
{
    private string name;

    public Temp(string Name)
    {
        name = Name;
    }
}*/