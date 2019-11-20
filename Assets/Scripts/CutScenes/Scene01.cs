using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01 : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;
    public GameObject Fadeout;
    public GameObject Fadein;
    public GameObject ThePlayer;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CutsceneStart());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CutsceneStart()
    {
        yield return new WaitForSeconds(5.0f);
        Camera2.SetActive(true);
        Camera1.SetActive(false);
        Fadein.SetActive(false);

        yield return new WaitForSeconds(10.0f);
        Camera3.SetActive(true);
        Camera2.SetActive(false);

        yield return new WaitForSeconds(4.0f);
        Fadeout.SetActive(true);

        yield return new WaitForSeconds(1.0f);
        ThePlayer.SetActive(true);
        Fadein.SetActive(true);
        Camera3.SetActive(false);
        Fadeout.SetActive(false);

        yield return new WaitForSeconds(1.0f);
    }
}
