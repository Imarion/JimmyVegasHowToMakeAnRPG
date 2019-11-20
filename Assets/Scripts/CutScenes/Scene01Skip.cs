﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01Skip : MonoBehaviour
{
    public GameObject FadeIn;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeQuit());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FadeQuit()
    {
        yield return new WaitForSeconds(1.0f);
        FadeIn.SetActive(false);
    }
}
