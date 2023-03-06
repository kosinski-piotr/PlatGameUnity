﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingHere : MonoBehaviour
{
    public GameObject hero;
    public float smooth;
    private Vector3 currVelocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newCameraPosition = new Vector3(hero.transform.position.x, transform.position.y, transform.position.z);

        transform.position = Vector3.SmoothDamp(transform.position, newCameraPosition, ref currVelocity, smooth);

    }
}
