using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LinearRockMovement : MonoBehaviour
{
    [SerializeField] Transform[] Positions;
    [SerializeField] float speed;
    Transform nextPos;
    int nextPosIndex;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = Positions[0].position;
        nextPos = Positions[0];
    }

    // Update is called once per frame
    void Update()
    {
        MoveObstacle();
    }
    void MoveObstacle()
    {
        if(transform.position == nextPos.position)
        {
            nextPosIndex++;
            if(nextPosIndex >= Positions.Length)
            {
                nextPosIndex = 0;
            }
            nextPos = Positions[nextPosIndex];
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, nextPos.position, speed * Time.deltaTime);
        }
    }
}