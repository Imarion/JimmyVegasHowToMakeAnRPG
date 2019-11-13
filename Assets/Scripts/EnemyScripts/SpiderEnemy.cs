using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderEnemy : MonoBehaviour
{
    public int EnemyHealth = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    void DeductPoints(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyHealth <= 0)
        {
            StartCoroutine(DeathSpider());
        }
    }

    IEnumerator DeathSpider()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
