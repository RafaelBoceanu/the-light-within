using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MessageDisplay : MonoBehaviour
{
    public Transform messageUI;
    public Light pointLight;
    TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        text = messageUI.GetChild(1).GetComponent<TextMeshProUGUI>();
    }

    IEnumerator DoYesNo(string message, Action<bool> callback)
    {
        message += "\n(Yes/No)";
        messageUI.gameObject.SetActive(true);
        text.text = message;
        bool answer = false;
        while (true)
        {
            if (Input.GetKeyDown("n"))
            {
                pointLight.range -= 5;
                answer = false;
                break;
            }
            if (Input.GetKeyDown("y"))
            {
                pointLight.range += 5;
                answer = true;
                break;
            }
            yield return null;
        }
        messageUI.gameObject.SetActive(false);
        callback(answer);
    }

    IEnumerator Message(string message, float seconds)
    {
        messageUI.gameObject.SetActive(true);
        text.text = message;
        yield return new WaitForSeconds(seconds);
        messageUI.gameObject.SetActive(false);
    }

    public void YesNoMessage(string message, Action<bool> answerFunc)
    {
        StartCoroutine(DoYesNo(message, answerFunc));
    }

    public void ShowMessage(string message, float seconds)
    {
        StartCoroutine(Message(message, seconds));
    }
}
