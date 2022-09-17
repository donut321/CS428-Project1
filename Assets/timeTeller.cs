using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class timeTeller : MonoBehaviour
{
    public GameObject chicagoTimeObject;
    public GameObject englandTimeObject;
    public TimeZoneInfo chicagoTime = TimeZoneInfo.FindSystemTimeZoneById("CST6CDT");
    public TimeZoneInfo englandTime = TimeZoneInfo.FindSystemTimeZoneById("Europe/London");

    // Start is called before the first frame update
    void Start()
    {
    InvokeRepeating("UpdateTime", 0f, 01f);
    }


    void UpdateTime()
    {
    DateTime CST6CDT = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, chicagoTime);
    DateTime GMT1 = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, englandTime);
    chicagoTimeObject.GetComponent<TextMeshPro>().text = ($"{CST6CDT} \n");
    englandTimeObject.GetComponent<TextMeshPro>().text = ($"{GMT1} \n");
    //Show Text
    }
}
