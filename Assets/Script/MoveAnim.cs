﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnim : MonoBehaviour
{
    Vector3 dir;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * Time.deltaTime);
    }

    private void Start()
    {
        resetAnim();
    }
    public void resetAnim()
    {
        transform.position = new Vector3(0, 4.85f, 0) ;
        dir = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), -1).normalized;
    }
}
