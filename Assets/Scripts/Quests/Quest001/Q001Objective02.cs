﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q001Objective02 : MonoBehaviour
{

    public float TheDistance;
    public GameObject Treasurechest;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject TheObjective;
    public GameObject TakeSword;
    public int CloseObjective = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;

        if (CloseObjective == 3)
        {
            TheObjective.SetActive(true);
            if (TheObjective.transform.localScale.y <= 0.0f)
            {
                CloseObjective = 0;
                TheObjective.SetActive(false);
            }
            else
            {
                TheObjective.transform.localScale -= new Vector3(0.0f, 0.01f, 0.0f);
            }
        }
    }

    private void OnMouseOver()
    {
        if (TheDistance <= 3)
        {
            ActionText.GetComponent<Text>().text = "Open Chest";
            ActionText.SetActive(true);
            ActionDisplay.SetActive(true);

            if (Input.GetButtonDown("Action"))
            {
                this.GetComponent<BoxCollider>().enabled = false;
                Treasurechest.GetComponent<Animation>().Play("Q01ChestOpen");
                TakeSword.SetActive(true);
                CloseObjective = 3;
                ActionText.SetActive(false);
                ActionDisplay.SetActive(false);
            }
        }
    }

    private void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }


}
