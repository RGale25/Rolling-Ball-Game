﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate((20 * Vector3.right) * Time.deltaTime);
        transform.Rotate((20 * Vector3.up) * Time.deltaTime);
    }
}
