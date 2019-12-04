using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControls : MonoBehaviour
{
    public GameObject MenuSlider;
    public GameObject AnywhereText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SlideMenu()
    {
        MenuSlider.GetComponent<Animation>().Play("MainMenuSlide");
        Destroy(AnywhereText);
        Destroy(this);
    }
}
