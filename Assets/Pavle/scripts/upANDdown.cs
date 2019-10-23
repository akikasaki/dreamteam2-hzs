﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upANDdown : MonoBehaviour
{
    public Transform posA;
    public Transform posB;
    public float speed;
    public Transform startPos;

    Vector3 nextPos;

    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == posA.position)
        {
            nextPos = posB.position;
        }
        if (transform.position == posB.position)
        {
            nextPos = posA.position;
        }

        transform.position = Vector2.MoveTowards(transform.position, nextPos,speed);
    }
}
