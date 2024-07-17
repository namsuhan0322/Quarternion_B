using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // 과제 똥피하기 게임
    public int _int = 0;

    public int[] ints = new int[10];
    public List<int> intList;

    public List<Item> itemObjList = new List<Item>();

    public Item item;

    void Start()
    {
        while (_int < 3)
        {
            Debug.Log($"while : {_int}");
            _int++;
        }

        for (int i = 0; i < 3; i++)
        {
            Debug.Log($"for : {i}");
        }

        for (int i = 0; i < ints.Length; i++)
        {
            ints[i] = Random.Range(0, 20);
        }

        foreach (int i in ints)
        {
            if (i % 2 ==0) Debug.Log($"foreach : {i}");
        }

        for (int i = 0; i < ints.Length; i++)
        {
            if (ints[i] % 2 == 0) Debug.Log(ints[i]);
        }

        Debug.Log($"itemObjList : {itemObjList[0].name}");

        Debug.Log($"item : {item.name}");
    }
}
