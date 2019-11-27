using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpiderBossAI : MonoBehaviour
{

    public GameObject TheDestination;

    NavMeshAgent TheAgent;

    // Start is called before the first frame update
    void Start()
    {
        TheAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        TheAgent.SetDestination(TheDestination.transform.position);
    }
}
