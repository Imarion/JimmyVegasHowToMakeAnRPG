﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest001Take : MonoBehaviour
{

    public float TheDistance;
    public GameObject ActionKey;
    public GameObject ActionText;
    public GameObject UIQuest;
    public GameObject ThePlayer;
    public GameObject NoticeCam;
    public GameObject MiniMap;    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    private void OnMouseOver()
    {
        if (TheDistance <= 3)
        {
            AttackBlocker.BlockSword = 1;
            ActionKey.SetActive(true);
            ActionText.SetActive(true);

            if (Input.GetButtonDown("Action"))
            {
                MiniMap.SetActive(false);
                AttackBlocker.BlockSword = 2;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                ActionKey.SetActive(false);
                ActionText.SetActive(false);
                UIQuest.SetActive(true);
                NoticeCam.SetActive(true);
                ThePlayer.SetActive(false);
                MasterQuest.mainQuestName = "Find the sword.";
                MasterQuest.mainQuestInfo = "I have to find the sword which is said to be inside a chest in the forest.";
            }
        }
    }

    private void OnMouseExit()
    {
        ActionKey.SetActive(false);
        ActionText.SetActive(false);
        AttackBlocker.BlockSword = 0;
    }
}
