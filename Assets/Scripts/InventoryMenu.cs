using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class InventoryMenu : MonoBehaviour
{
    public bool invOpen;
    public GameObject invMenu;
    public GameObject thePlayer;

    public GameObject ItemPanel;
    public GameObject QuestPanel;
    public GameObject StatsPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (invOpen == false)
            {
                Time.timeScale = 0;
                invOpen = true;
                Cursor.visible = true;
                invMenu.SetActive(true);
                thePlayer.GetComponent<FirstPersonController>().enabled = false;
            }
            else
            {
                invMenu.SetActive(false);
                Cursor.visible = false;
                invOpen = false;
                Time.timeScale = 1;
                thePlayer.GetComponent<FirstPersonController>().enabled = true;

                ItemPanel.SetActive(false);
                QuestPanel.SetActive(false);
                StatsPanel.SetActive(false);
            }
        }
    }

    public void ShowItems()
    {
        ItemPanel.SetActive(true);
        QuestPanel.SetActive(false);
        StatsPanel.SetActive(false);
    }

    public void ShowQuests()
    {
        ItemPanel.SetActive(false);
        QuestPanel.SetActive(true);
        StatsPanel.SetActive(false);
    }

    public void ShowStats()
    {
        ItemPanel.SetActive(false);
        QuestPanel.SetActive(false);
        StatsPanel.SetActive(true);
    }

    public void Close()
    {
        invMenu.SetActive(false);
        Cursor.visible = false;
        invOpen = false;
        Time.timeScale = 1;
        thePlayer.GetComponent<FirstPersonController>().enabled = true;

        ItemPanel.SetActive(false);
        QuestPanel.SetActive(false);
        StatsPanel.SetActive(false);
    }
}
