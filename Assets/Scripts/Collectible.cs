using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public string itemName;

    MessageDisplay disp;

    private void Start()
    {
        disp = GameObject.Find("MessageDisplayer").GetComponent<MessageDisplay>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Inventory>().Add(itemName, 1);
            disp.ShowMessage("You picked up a " + itemName, 2.0f);
            Destroy(gameObject);
        }
    }
}
