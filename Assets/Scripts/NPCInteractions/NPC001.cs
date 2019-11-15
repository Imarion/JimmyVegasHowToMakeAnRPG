using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC001 : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionKey;
    public GameObject ActionText;
    public GameObject ThePlayer;
    public GameObject TextBox;
    public GameObject NPCName;
    public GameObject NPCText;

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
            ActionText.GetComponent<Text>().text = "Talk";
            ActionKey.SetActive(true);
            ActionText.SetActive(true);

            if (Input.GetButtonDown("Action"))
            {
                AttackBlocker.BlockSword = 2;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                ActionKey.SetActive(false);
                ActionText.SetActive(false);
                //ThePlayer.SetActive(false);
                StartCoroutine(NPC001Active());
            }
        }
    }

    private void OnMouseExit()
    {
        ActionKey.SetActive(false);
        ActionText.SetActive(false);
        AttackBlocker.BlockSword = 0;
    }

    IEnumerator NPC001Active()
    {
        TextBox.SetActive(true);
        NPCName.GetComponent<Text>().text = "Warrior";
        NPCName.SetActive(true);
        NPCText.GetComponent<Text>().text = "Hello friend, I may have a quest for you if you wish to accept it. Please come back later on this afternoon.";
        NPCText.SetActive(true);

        yield return new WaitForSeconds(5.5f);

        NPCName.SetActive(false);
        NPCText.SetActive(false);
        TextBox.SetActive(false);
        ActionKey.SetActive(true);
        ActionText.SetActive(true);


    }
}
