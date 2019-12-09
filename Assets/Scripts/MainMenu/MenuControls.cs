using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public GameObject MenuSlider;
    public GameObject AnywhereText;
    public GameObject ClickAnywhereButton;
    public AudioSource menuMusic;
    public GameObject loadingGame;

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
        Destroy(ClickAnywhereButton);
        Destroy(this);
    }

    public void NewGame()
    {
        menuMusic.Stop();
        loadingGame.SetActive(true);
        SceneManager.LoadScene(1);
    }
}
