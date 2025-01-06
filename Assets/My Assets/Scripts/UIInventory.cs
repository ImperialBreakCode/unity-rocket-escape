using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIInventory : MonoBehaviour
{
    private TextMeshProUGUI _inventoryText;

    // Start is called before the first frame update
    void Start()
    {
        _inventoryText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateInventoryText(PlayerInventory inventory)
    {
        _inventoryText.text = inventory.NumberOfScrews.ToString() + "/3";
    }

    public void HideText()
    {
        gameObject.SetActive(false);
    }
}
