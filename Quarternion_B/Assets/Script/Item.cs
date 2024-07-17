using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "New Item/item", order = 3)]
public class Item : ScriptableObject
{
    public string name;
    public int id;
    public int age;
}
