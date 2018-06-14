using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ComponentInfo
{
    public BuildComponent component;
    public int amount;

    public void Add()
    {
        component.amount += amount;
    }

    public void Subtract()
    {
        component.amount -= amount;
    }

    public bool Pass
    {
        get
        {
            return amount <= component.amount ? true : false;
        }
    }
}

public class CraftingSystem : MonoBehaviour
{
}
