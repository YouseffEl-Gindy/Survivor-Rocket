using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuitButton : MonoBehaviour
{
    [SerializeField] Button quitButton;
    // Start is called before the first frame update
    void Start()
    {
        quitButton.onClick.AddListener(ButtonAction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ButtonAction()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
