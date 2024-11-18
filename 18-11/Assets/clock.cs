using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class clock : MonoBehaviour
{
    public Transform MinuteArmPivot;
    public Transform HoursArmPivot;

    private void Start()
    {
        HoursArmPivot.localRotation = Quaternion.Euler(0, 0, -150);
    }

    private void Update()
    {
        DateTime t = DateTime.Now;
        HoursArmPivot.localRotation = Quaternion.Euler(0, 0, -30 * t.Hour);
        MinuteArmPivot.localRotation = Quaternion.Euler(0, 0, -6 * t.Minute);
    }
}
