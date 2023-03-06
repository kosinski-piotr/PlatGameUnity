﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartPoint : MonoBehaviour
{
    RestartPointManager restartPointManager;
    SpriteRenderer sprRenderer;

    // Start is called before the first frame update
    void Start()
    {
        restartPointManager = GameObject.Find("Manager").GetComponent<RestartPointManager>();
        sprRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            restartPointManager.UpdateStartPoint(this.gameObject.transform);
            sprRenderer.color = new Color(0.5f, 0.7f, 0.5f);
        }
    }
}
