using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetClockTime : MonoBehaviour
{
    public Transform secondHand;
    public Transform minuteHand;
    public Transform hourHand;

    private const float HoursToDegrees = 360f / 12f, MinutesToDegrees = 360f/60f, SecondsToDegrees = 360f / 60f;
    

    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;
        hourHand.localRotation = Quaternion.Euler(time.Hour * HoursToDegrees +90f, 0f, -90f);
        minuteHand.localRotation = Quaternion.Euler(time.Minute * MinutesToDegrees + 90f, 0f, -90f);
        secondHand.localRotation = Quaternion.Euler(time.Second * SecondsToDegrees + 90f, 0f, -90f);
    }

}