using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderAI : MonoBehaviour
{

    public GameObject ThePlayer;
    public float TargetDistance;
    public float AllowedRange = 40.0f;
    public GameObject TheEnemy;
    public float EnemySpeed;
    public int AttackTrigger;
    public RaycastHit Shot;
    public int DealingDamage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(ThePlayer.transform);
        if (Physics.Raycast(transform.position, transform.forward, out Shot))
        {
            TargetDistance = Shot.distance;
            if (TargetDistance <= AllowedRange)
            {
                EnemySpeed = 0.05f;
                if (AttackTrigger == 0)
                {
                    TheEnemy.GetComponent<Animation>().Play("walk");
                    transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, EnemySpeed);
                }
            }
            else
            {
                EnemySpeed = 0;
                TheEnemy.GetComponent<Animation>().Play("idle");
            }
        }

        if (AttackTrigger == 1)
        {
            if (DealingDamage == 0)
            {
                EnemySpeed = 0;
                TheEnemy.GetComponent<Animation>().Play("attack");
                StartCoroutine(TakingDamage());
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        AttackTrigger = 1;
    }

    private void OnTriggerExit(Collider other)
    {
        AttackTrigger = 0;
    }

    IEnumerator TakingDamage()
    {
        DealingDamage = 2;
        yield return new WaitForSeconds(0.5f);
        if (SpiderEnemy.GlobalSpider != 6)
        {
            HealthMonitor.HealthValue -= 10;
        }
        yield return new WaitForSeconds(0.4f);
        DealingDamage = 0;
    }
}
