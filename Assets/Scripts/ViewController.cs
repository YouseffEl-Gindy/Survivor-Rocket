using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewController : MonoBehaviour
{
    public GameObject Player;
    public GameObject backGround;
    public GameObject Camera;

    // X distance between Camera and player
    float xDistOfCamera;
    


    // X distance between Background  and player
    float xDistOfBackgound;
    

    // Start is called before the first frame update
    void Start()
    {
        xDistOfCamera = Camera.transform.position.x - Player.transform.position.x;
        xDistOfBackgound = backGround.transform.position.x - Player.transform.position.x;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float playerX = Player.transform.position.x;
        float playerY = Player.transform.position.y;


        Camera.transform.position = new Vector3(playerX + xDistOfCamera , playerY, Camera.transform.position.z);
        backGround.transform.position = new Vector3(playerX + xDistOfBackgound , playerY, backGround.transform.position.z);
    }
}
