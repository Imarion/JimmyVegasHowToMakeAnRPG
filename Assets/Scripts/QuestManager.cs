using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public static int ActiveQuestNumber;
    public int InternalQuestNumber;

    public GameObject MainMark; // Quest guide arrow
    public GameObject Objective01Mark;
    public GameObject Objective02Mark;
    public GameObject Objective03Mark;

    public static int SubquestNumber;
    public int InternalSubquestNumber;

    public GameObject Pointer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InternalQuestNumber = ActiveQuestNumber;
        InternalSubquestNumber = SubquestNumber;
        Pointer.transform.LookAt(MainMark.transform);

        if (InternalSubquestNumber == 0)
        {
            Pointer.SetActive(false);
        }
        else
        {
            Pointer.SetActive(true);
        }

        if (InternalSubquestNumber == 1)
        {
            MainMark.transform.position = Objective01Mark.transform.position;
        }
        if (InternalSubquestNumber == 2)
        {
            MainMark.transform.position = Objective02Mark.transform.position;
        }
        if (InternalSubquestNumber == 3)
        {
            MainMark.transform.position = Objective03Mark.transform.position;
        }
    }
}
