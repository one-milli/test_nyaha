﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Update collision
    void onCollisionEnter(Collision col)
    {
        Destroy(this.gameObject);
    }
}
