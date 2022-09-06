using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HowToPlayButton : MonoBehaviour
{
    [SerializeField] Button howToPlayButton;

    // Start is called before the first frame update
    void Start()
    {
        howToPlayButton.onClick.AddListener(ButtonAction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ButtonAction()
    {
        SceneManager.LoadScene("Introduction");
    }
}
