using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGold : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("GoldAmountSave", GlobalCash.GoldAmount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
