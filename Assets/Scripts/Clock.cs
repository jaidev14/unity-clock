using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    bool digital = false;
    [SerializeField]
    private Transform hoursPivot, minutesPivot, secondsPivot;
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secoondsToDegrees = -6f;

    void Update()
    {
        // Digital clock
        if (digital) 
        {
            var time = DateTime.Now;
            hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * time.Hour);
            minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * time.Minute);
            secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secoondsToDegrees * time.Second);
        } 
        // Analog clock
        else 
        {
            TimeSpan time = DateTime.Now.TimeOfDay;
            hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
            minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
            secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secoondsToDegrees * (float)time.TotalSeconds);
        }

    }
}
