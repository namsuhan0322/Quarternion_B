using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Poop", menuName = "New Poop/Poop")]
public class PoopObj : ScriptableObject
{
    public enum PoopType
    {
        Poop,
        GoldPoop
    }

    public PoopType poopType;
    public string name;
}
