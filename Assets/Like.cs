﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Like : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Player>().count += 10;
        }
        Destroy(gameObject);
    }
}
