using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001Buttons : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject NoticeCam;
    public GameObject UIQuest;
    public GameObject ActiveQuestBox;
    public GameObject Objective01;
    public GameObject Objective02;
    public GameObject Objective03;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AcceptQuest()
    {
        ThePlayer.SetActive(true);
        NoticeCam.SetActive(false);
        UIQuest.SetActive(false);
        StartCoroutine(SetQuestUI());
    }

    public void DeclineQuest()
    {
        ThePlayer.SetActive(true);
        NoticeCam.SetActive(false);
        UIQuest.SetActive(false);
    }

    IEnumerator SetQuestUI()
    {
        ActiveQuestBox.GetComponent<Text>().text = "My first weapon";
        Objective01.GetComponent<Text>().text = "Reach the clearing in the wood";
        Objective02.GetComponent<Text>().text = "Open the chest";
        Objective03.GetComponent<Text>().text = "Retrieve the weapon";
        QuestManager.ActiveQuestNumber = 1;

        yield return new WaitForSeconds(0.5f);
        ActiveQuestBox.SetActive(true);
        yield return new WaitForSeconds(1f);
        Objective01.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Objective02.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Objective03.SetActive(true);
        yield return new WaitForSeconds(9.0f);
        ActiveQuestBox.SetActive(false);
        Objective01.SetActive(false);
        Objective02.SetActive(false);
        Objective03.SetActive(false);
    }
}
