﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour
{
    public GameObject carControl;
    public GameObject dreamCar01;

    // Start is called before the first frame update
    void Start()
    {
        // carControl.GetComponent<CarController>().enabled = true;
        dreamCar01.GetComponent<CarAIControl>().enabled = true;
    }
}
