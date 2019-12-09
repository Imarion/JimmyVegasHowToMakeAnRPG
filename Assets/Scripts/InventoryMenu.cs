using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class InventoryMenu : MonoBehaviour
{
    public bool invOpen;
    public GameObject invMenu;
    public GameObject thePlayer;

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
            }
        }
    }
}
