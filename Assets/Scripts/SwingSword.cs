using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingSword : MonoBehaviour
{
    public GameObject Sword;
    public int SwordStatus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && SwordStatus == 0 && AttackBlocker.BlockSword == 0)
        {
            StartCoroutine(Swing());
        }
    }

    IEnumerator Swing()
    {
        SwordStatus = 1;
        Sword.GetComponent<Animation>().Play("ElvenSwordAnim");

        SwordStatus = 2;
        yield return new WaitForSeconds(1.0f);

        SwordStatus = 0;
    }
}
