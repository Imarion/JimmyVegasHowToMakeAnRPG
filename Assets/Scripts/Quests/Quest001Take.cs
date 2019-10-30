using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest001Take : MonoBehaviour
{

    public float TheDistance;
    public GameObject ActionKey;
    public GameObject ActionText;
    public GameObject UIQuest;
    public GameObject ThePlayer;
    public GameObject NoticeCam;

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

            if (Input.GetButtonDown("Action"))
            {
                ActionKey.SetActive(false);
                ActionText.SetActive(false);
                UIQuest.SetActive(true);
                NoticeCam.SetActive(true);
                ThePlayer.SetActive(false);
            }
        }
    }

    private void OnMouseExit()
    {
        ActionKey.SetActive(false);
        ActionText.SetActive(false);
    }
}
