using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftableObject : MonoBehaviour
{
    public List<ComponentInfo> requirements;
    public List<ComponentInfo> salvage;

    private void Update()
    {
        PlayerInput();
    }

    private void PlayerInput()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Salvage();
        }
    }

    private void Craft()
    {
        foreach(ComponentInfo info in salvage)
        {
            info.Subtract();
        }
    }

    private void Salvage()
    {
        foreach(ComponentInfo info in salvage)
        {
            info.Add();
        }
        gameObject.SetActive(false);
    }

    private void ComponentTest()
    {
        if (requirements.Count == 0)
            return;

        for (int i = 0; i < requirements.Count; i++)
        {
            Debug.Log(requirements[i].component.name + ": " + (requirements[i].Pass ? "pass" : "fail"));
        }
    }
}
