using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q001Objective01 : MonoBehaviour
{
    public GameObject TheObjective;
    public int CloseObjective = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CloseObjective == 1)
        {
            if (TheObjective.transform.localScale.y <= 0.0f)
            {
                CloseObjective = 0;
                TheObjective.SetActive(false);
            }
            else
            {
                TheObjective.transform.localScale -= new Vector3(0.0f, 0.01f, 0.0f);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        QuestManager.SubquestNumber = 2;
        GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(FinishObjective());
    }

    IEnumerator FinishObjective()
    {
        TheObjective.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        CloseObjective = 1;
    }
}
