using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public static int ActiveQuestNumber;
    public int InternalQuestNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InternalQuestNumber = ActiveQuestNumber;
    }
}
