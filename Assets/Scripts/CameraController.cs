using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public void Update()
    {
        UpdateRaycast();
    }

    private void UpdateRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            CraftableObject craftableObject = hit.transform.GetComponent<CraftableObject>();
            if (craftableObject)
            {
                UserInterface.UpdateComponentHUD(craftableObject);
            }
            else
            {
                UserInterface.HideComponentHUD();
            }
        }
        else
        {
            UserInterface.HideComponentHUD();
        }
    }
}
