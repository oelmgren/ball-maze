﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other) {
      if(other.name == "goal") {
        Destroy(gameObject,.5f);
        Debug.Log("You Win!");
      }
    }
}
