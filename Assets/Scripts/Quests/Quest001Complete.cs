using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001Complete : MonoBehaviour
{

    public float TheDistance;
    public GameObject ActionKey;
    public GameObject ActionText;
    public GameObject UIQuest;
    public GameObject ThePlayer;
    public GameObject ExMark;
    public GameObject CompleteTrigger;

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
            ActionKey.SetActive(true);
            ActionText.SetActive(true);
            ActionText.GetComponent<Text>().text = "Complete quest";

            if (Input.GetButtonDown("Action"))
            {
                // Cursor.lockState = CursorLockMode.None;
                // Cursor.visible = true;
                ExMark.SetActive(false);
                GlobalExp.CurrentExp += 100;
                ActionKey.SetActive(false);
                ActionText.SetActive(false);
                CompleteTrigger.SetActive(false);
            }
        }
    }

    private void OnMouseExit()
    {
        ActionKey.SetActive(false);
        ActionText.SetActive(false);
    }
}
