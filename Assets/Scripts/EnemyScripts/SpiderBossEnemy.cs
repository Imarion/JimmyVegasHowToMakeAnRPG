using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBossEnemy : MonoBehaviour
{
    public int EnemyHealth = 20;
    public GameObject TheSpider;
    public int SpiderStatus;
    public int BaseXP = 10;
    public int CalculatedXP;
    public SpiderBossAI SpiderBossAIScript;

    public GameObject OldNPC;
    public GameObject NewNPC;
    public SpiderBossAttack spiderBossAttackScript;

    public static int GlobalSpider;

    // Start is called before the first frame update
    void Start()
    {
        SpiderBossAIScript = GetComponent<SpiderBossAI>();
        spiderBossAttackScript = GetComponent<SpiderBossAttack>();
    }

    void DeductPoints(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    // Update is called once per frame
    void Update()
    {
        GlobalSpider = SpiderStatus;
        if (EnemyHealth <= 0)
        {
            if (SpiderStatus == 0)
            {
                StartCoroutine(DeathSpider());
            }
        }
    }

    IEnumerator DeathSpider()
    {
        SpiderBossAIScript.enabled = false;
        spiderBossAttackScript.enabled = false;
        SpiderStatus = 6;
        CalculatedXP = BaseXP * GlobalLevel.CurrentLevel;
        GlobalXP.CurrentXP += CalculatedXP;
        yield return new WaitForSeconds(0.5f);
        TheSpider.GetComponent<Animation>().Play("die");
        //Destroy(gameObject);
        yield return new WaitForSeconds(0.5f);
        TheSpider.GetComponent<Animation>().enabled = false;

        OldNPC.SetActive(false);
        NewNPC.SetActive(true);

        QuestManager.SubquestNumber = 4;
    }
}
