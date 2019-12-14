using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InflictDamage : MonoBehaviour
{
    public int DamageAmount = 5;
    public float TargetDistance;
    public float AllowedRange = 2.7f;
    public AudioSource SwingSwordAudio;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && SwingSword.isSwinging == false)
        {
            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                TargetDistance = hit.distance;
                if (TargetDistance <= AllowedRange)
                {
                    SwingSwordAudio.Play();
                    hit.transform.SendMessage("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }
}
