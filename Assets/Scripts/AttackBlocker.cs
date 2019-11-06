using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBlocker : MonoBehaviour
{
    public static int BlockSword;
    public int InternalBlock;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InternalBlock = BlockSword;
    }
}
