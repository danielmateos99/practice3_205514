﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(20, 20, 20) * Time.deltaTime);
    }
}