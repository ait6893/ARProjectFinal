using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleScatter : MonoBehaviour
{
    bool scattered = false;

    float PosX, PosY, PosZ;
    float RandPosX, RandPosY, RandPosZ;

    public Rigidbody rigi;
    Vector3 vect3;

    bool moving = false;
    public float initialMoveSpeedX = 0.04f;
    public float initialMoveSpeedZ = 0.08f;
    public int moveDuration = 240;
    public int scatterRange = 4;
    float moveSpeedX;
    float moveSpeedZ;

    void Awake()
    {
        moveSpeedX = initialMoveSpeedX;
        moveSpeedZ = initialMoveSpeedZ;

        PosX = transform.position.x;
        PosY = transform.position.y;
        PosZ = transform.position.z;

        RandPosX = Mathf.Round(Random.Range(-scatterRange, scatterRange));
        RandPosY = Random.Range(0, 0);
        RandPosZ = Mathf.Round(Random.Range(-1, -scatterRange * 2));
    }

    void Start()
    {
        Scatter();
    }

    void Update()
    {
        if(moving && scattered)
        {
            if (transform.position.x > RandPosX && RandPosX < 0)
                vect3.x -= moveSpeedX;
            if (transform.position.x < RandPosX && RandPosX > 0)
                vect3.x += moveSpeedX;
            if (transform.position.z > RandPosZ)
                vect3.z -= moveSpeedZ;

            if (moveSpeedX > 0)
                moveSpeedX -= initialMoveSpeedX / moveDuration;

            if (moveSpeedZ > 0)
                moveSpeedZ -= initialMoveSpeedZ / moveDuration;

            if (moveSpeedX <= 0 && moveSpeedZ <= 0)
                moving = false;
        }
        transform.position = vect3;
    }

    public void Scatter()
    {
        if(!scattered)
        {
            scattered = true;
            moving = true;
            vect3 = transform.position;
            moveSpeedX = initialMoveSpeedX;
            moveSpeedZ = initialMoveSpeedZ;
        }
    }
}
