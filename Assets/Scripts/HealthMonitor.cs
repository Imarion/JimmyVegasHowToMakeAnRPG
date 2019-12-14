using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthMonitor : MonoBehaviour
{

    public static int HealthValue;
    public int internalHealth;
    public GameObject healthBar;

    //public GameObject Hearth1;
    //public GameObject Hearth2;
    //public GameObject Hearth3;



    // Start is called before the first frame update
    void Start()
    {
        HealthValue = 300;
    }

    // Update is called once per frame
    void Update()
    {
        internalHealth = HealthValue;

        if (HealthValue <= 0)
        {
            SceneManager.LoadScene(1);
        }

        healthBar.GetComponent<RectTransform>().sizeDelta = new Vector2(HealthValue, 30);

        /*
        if (HealthValue == 1)
        {
            //Hearth1.SetActive(true);
            //Hearth2.SetActive(false);
        }
        if (HealthValue == 2)
        {
            //Hearth2.SetActive(true);
            //Hearth3.SetActive(false);
        }
        if (HealthValue == 3)
        {
            //Hearth3.SetActive(true);
        }
        */
    }
}
