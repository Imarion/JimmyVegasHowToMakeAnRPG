using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC001_Comp : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionKey;
    public GameObject ActionText;
    public GameObject ThePlayer;
    public GameObject TextBox;
    public GameObject NPCName;
    public GameObject NPCText;

    public GameObject SmallSpider;
    public GameObject BossSpider;

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
        if (QuestManager.ActiveQuestNumber == 2 && QuestManager.SubquestNumber == 4)
        {
            TextBox.SetActive(true);
            NPCName.GetComponent<Text>().text = "Warrior";
            NPCName.SetActive(true);
            NPCText.GetComponent<Text>().text = "Thank you very much for your help. There is a cave outside the village. Please go explore.";
            //cave object set here
            QuestManager.ActiveQuestNumber = 3;
            QuestManager.SubquestNumber = 1;

            NPCText.SetActive(true);

            yield return new WaitForSeconds(5.5f);

            NPCName.SetActive(false);
            NPCText.SetActive(false);
            TextBox.SetActive(false);
            ActionKey.SetActive(true);
            ActionText.SetActive(true);

            SmallSpider.SetActive(true);
            BossSpider.SetActive(true);
        }
        else
        {
            TextBox.SetActive(true);
            NPCName.GetComponent<Text>().text = "Warrior";
            NPCName.SetActive(true);
            NPCText.GetComponent<Text>().text = "Please come and see me when you have explored the cave.";
            NPCText.SetActive(true);

            yield return new WaitForSeconds(5.5f);

            NPCName.SetActive(false);
            NPCText.SetActive(false);
            TextBox.SetActive(false);
            ActionKey.SetActive(true);
            ActionText.SetActive(true);
        }
    }
}
