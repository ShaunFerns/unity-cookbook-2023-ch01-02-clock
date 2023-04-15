using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClockDigital : MonoBehaviour
{
    private TMP_Text textClock;

    void Awake()
    {
        textClock = GetComponent<Text>();
    }

    void Update()
    {
        DateTime time = DateTime.Now;
        string hour = LeadingZero(time.Hour);
        string minute = LeadingZero(time.Minute);
        string second = LeadingZero(time.Second);

        textClock.text = hour + ":" + minute + ":" + second;
    }

    string LeadingZero(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
}
