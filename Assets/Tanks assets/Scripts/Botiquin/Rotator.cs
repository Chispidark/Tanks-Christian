﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 50, 0)* Time.deltaTime);
    }
}
