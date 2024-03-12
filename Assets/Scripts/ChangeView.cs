using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeView : MonoBehaviour
{
    public Camera behindVehicleCamera1;
    public Camera behindVehicleCamera2;
    public Camera inCarCamera1;
    public Camera inCarCamera2;

    void Update()
    {
        if (Input.GetButtonDown("Switch1"))
        {
            behindVehicleCamera1.enabled = false;
            inCarCamera1.enabled = true;
        }
        if (Input.GetButtonDown("Switch2"))
        {
            behindVehicleCamera1.enabled = true;
            inCarCamera1.enabled = false;
        }
        if (Input.GetButtonDown("Switch3"))
        {
            behindVehicleCamera2.enabled = false;
            inCarCamera2.enabled = true;
        }
        if (Input.GetButtonDown("Switch4"))
        {
            behindVehicleCamera2.enabled = true;
            inCarCamera2.enabled = false;
        }
    }
}