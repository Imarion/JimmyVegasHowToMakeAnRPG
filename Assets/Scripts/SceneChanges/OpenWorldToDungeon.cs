using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenWorldToDungeon : MonoBehaviour
{

    public float TheDistance;
    public GameObject ActionKey;
    public GameObject ActionText;
    public GameObject ThePlayer;

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
        if (TheDistance <= 20)
        {
            //AttackBlocker.BlockSword = 1;
            ActionText.GetComponent<Text>().text = "Enter Dungeon";
            ActionKey.SetActive(true);
            ActionText.SetActive(true);

            if (Input.GetButtonDown("Action"))
            {
                ActionKey.SetActive(false);
                ActionText.SetActive(false);
                SceneManager.LoadScene(3);
                //ThePlayer.SetActive(false);
            }
        }
    }

    private void OnMouseExit()
    {
        ActionKey.SetActive(false);
        ActionText.SetActive(false);
    }
}
