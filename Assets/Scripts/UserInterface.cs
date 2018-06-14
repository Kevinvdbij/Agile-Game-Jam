using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInterface : MonoBehaviour
{
    public static UserInterface ui;
    public ComponentHUD componentHUD;

    private void Awake()
    {
        if (!ui)
        {
            ui = this;
        }
        else
        {
            Debug.LogWarning("UI singleton instance already exists");
            Destroy(this);
        }
    }

    public static void UpdateComponentHUD(CraftableObject craftableObject)
    {
        ui.componentHUD.UpdateElements(craftableObject);
    }

    public static void HideComponentHUD()
    {
        ui.componentHUD.HideElements();
    }
}
