using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComponentHUD : MonoBehaviour
{
    public Text interactionText;
    public RectTransform componentContainer;
    public GameObject componentPrefab;
    public CanvasGroup canvasGroup;

    private string GetInteractionString(CraftableObject craftableObject)
    {
        return "(!) to use " + craftableObject.name;
    }

    public void UpdateElements(CraftableObject craftableObject)
    {
        interactionText.text = GetInteractionString(craftableObject);
        for (int i = 0; i < craftableObject.salvage.Count; i++)
        {
            RectTransform rect = Instantiate(componentPrefab, componentContainer).GetComponent<RectTransform>();
            rect.localPosition = new Vector2(rect.localPosition.x, -15 * i);
        }
        canvasGroup.alpha = 1;
    }

    public void HideElements()
    {
        canvasGroup.alpha = 0;
    }
}
