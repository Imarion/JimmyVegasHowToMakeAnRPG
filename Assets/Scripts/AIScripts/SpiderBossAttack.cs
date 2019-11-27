using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBossAttack : MonoBehaviour
{
    public GameObject TheEnemy;
    public int AttackTrigger;
    public int DealingDamage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (AttackTrigger == 0)
        {
            TheEnemy.GetComponent<Animation>().Play("walk");
        }
        if (AttackTrigger == 1)
        {
            if (DealingDamage == 0)
            {
                TheEnemy.GetComponent<Animation>().Play("attack");
                StartCoroutine(TakingDamage());
            }
        }
    }

    IEnumerator TakingDamage()
    {
        DealingDamage = 2;
        yield return new WaitForSeconds(1.1f);
        if (SpiderEnemy.GlobalSpider != 6)
        {
            HealthMonitor.HealthValue -= 1;
        }
        yield return new WaitForSeconds(0.4f);
        DealingDamage = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        AttackTrigger = 1;
    }

    private void OnTriggerExit(Collider other)
    {
        AttackTrigger = 0;
    }

}
