using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NecroWalkAI : MonoBehaviour
{

    public int Xpos;
    public int Zpos;
    public GameObject NPCdest;
    public float WalkSpeed = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        Zpos = Random.Range(148, 157);
        Xpos = Random.Range(100, 120);
        NPCdest.transform.position = new Vector3(Xpos, 0, Zpos);
        StartCoroutine(RunRandomWalk());
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(NPCdest.transform);
        transform.position = Vector3.MoveTowards(transform.position, NPCdest.transform.position, WalkSpeed);
    }

    IEnumerator RunRandomWalk()
    {
        yield return new WaitForSeconds(3f);
        Zpos = Random.Range(148, 157);
        Xpos = Random.Range(100, 120);
        NPCdest.transform.position = new Vector3(Xpos, 0, Zpos);
        StartCoroutine(RunRandomWalk());

    }
}
