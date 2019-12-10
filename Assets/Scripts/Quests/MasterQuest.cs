using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterQuest : MonoBehaviour
{

    public GameObject mainQuestText;
    public GameObject mainQuestDesc;

    public static string mainQuestName;
    public static string mainQuestInfo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mainQuestText.GetComponent<Text>().text = mainQuestName;
        mainQuestDesc.GetComponent<Text>().text = mainQuestInfo;
    }
}
