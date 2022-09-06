using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BegainOfGame : MonoBehaviour
{
    [SerializeField] Button begainOfTheGame;

    // Start is called before the first frame update
    void Start()
    {
        begainOfTheGame.onClick.AddListener(ButtonAction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ButtonAction()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
