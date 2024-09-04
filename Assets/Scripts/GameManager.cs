using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform inventoryUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InventoryDisplay();
    }

    void InventoryDisplay()
    {
        string inv = GameObject.Find("PlayerCapsule").GetComponent<Inventory>().GetInventoryString();
        inventoryUI.GetChild(1).GetComponent<TextMeshProUGUI>().text = inv;
    }
}
