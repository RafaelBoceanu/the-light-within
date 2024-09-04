using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0;
    float startingTime = 30;
    Light pointLight;

    // Start is called before the first frame update
    void Start()
    {
        pointLight = GetComponentInChildren<Light>();

        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        if (currentTime <= 0)
        {
            pointLight.range -= 1;
            currentTime = startingTime;
        }
    }
}
