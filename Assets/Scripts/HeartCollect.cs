using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCollect : MonoBehaviour
{

    public int rotateSpeed = 2;
    public AudioSource collectSound;
    public GameObject thisHeart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        HealthMonitor.HealthValue++;
        thisHeart.SetActive(false);
    }
}
