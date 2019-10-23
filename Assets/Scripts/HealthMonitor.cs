using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthMonitor : MonoBehaviour
{

    public static int HealthValue;
    public int internalHealth;
    public GameObject Hearth1;
    public GameObject Hearth2;
    public GameObject Hearth3;



    // Start is called before the first frame update
    void Start()
    {
        HealthValue = 1;
    }

    // Update is called once per frame
    void Update()
    {
        internalHealth = HealthValue;

        if (HealthValue == 1)
        {
            Hearth1.SetActive(true);
        }
        if (HealthValue == 2)
        {
            Hearth2.SetActive(true);
        }
        if (HealthValue == 3)
        {
            Hearth3.SetActive(true);
        }
    }
}
