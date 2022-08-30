using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public GameObject hourHand;
    public GameObject minuteHand;
    public GameObject secondHand;    

    private Transform clockHandSecondsTransform;
    private Transform clockHandMinutesTransform;
    private Transform clockHandHourTransform;
    private Transform clockBodyTransform;

    private const float hoursToDegress = 360 / 12;
    private const float minutesToDegrees = 360 / 60;
    private const float secondsToDegrees = 360 / 120;

    private void Awake()
    {
        clockBodyTransform = this.gameObject.transform;
        clockHandHourTransform = hourHand.transform;
        clockHandMinutesTransform = minuteHand.transform;
        clockHandSecondsTransform = secondHand.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float seconds = float.Parse(DateTime.UtcNow.ToLocalTime().ToString("ss"));
        float minutes = float.Parse(DateTime.UtcNow.ToLocalTime().ToString("mm"));
        float hour = float.Parse(DateTime.UtcNow.ToLocalTime().ToString("hh"));

        clockHandHourTransform.eulerAngles = new Vector3(hour * hoursToDegress, clockBodyTransform.localEulerAngles.y, 0);
                
        clockHandMinutesTransform.eulerAngles = new Vector3(minutes * minutesToDegrees, clockBodyTransform.localEulerAngles.y, 0);

        clockHandSecondsTransform.eulerAngles = new Vector3(seconds * secondsToDegrees, clockBodyTransform.localEulerAngles.y, 0);
    }

}
