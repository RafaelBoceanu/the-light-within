using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMessage : MonoBehaviour
{
    public Inventory inventory;
    MessageDisplay messageDisplay;

    // Start is called before the first frame update
    void Start()
    {
        messageDisplay = GameObject.Find("MessageDisplayer").GetComponent<MessageDisplay>();
    }

    void HopeCallback(bool answer)
    {
        if (answer)
        {
            inventory.Remove("glimmer of hope", 1);
            messageDisplay.ShowMessage("You have really helped me! I can see your light growing!", 3);

            this.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Inventory inv = other.gameObject.GetComponent<Inventory>();
            bool hasSphere = inv.GetCount("glimmer of hope") > 0;

            if (!hasSphere)
            {
                messageDisplay.ShowMessage("I need just a glimmer of hope, are you willing to help me?", 3);
                messageDisplay.pointLight.range -= 2;
            }
            else
                messageDisplay.YesNoMessage("Can you give me just a glimmer of hope please?", HopeCallback);
        }
    }
}
