using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{

    [SerializeField] GameObject Player;

    //X distance between the player and spawner
    float xDistanceOfPlayer;


    // Maximum and minimum Y position of the Rock
    [SerializeField] float maxY;
    [SerializeField] float minY;

    // X offset of collision game object
    [SerializeField] float xOffset;

    // Start is called before the first frame update
    void Start()
    {
        xDistanceOfPlayer = Player.transform.position.x - transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float playerY = Player.transform.position.y;
        transform.position = new Vector3(Player.transform.position.x - xDistanceOfPlayer, playerY, transform.position.z);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Rock"))
        {
            Debug.Log("Rock", this);
            float yRange = Random.Range(minY, maxY);
            Debug.Log(yRange, this);
            collision.transform.position = new Vector3(collision.transform.position.x + xOffset, yRange, collision.transform.position.z);
        }
    }
}
