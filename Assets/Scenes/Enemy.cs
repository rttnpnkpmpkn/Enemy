using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;

    public float fireRate = 0.3f;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        move();
    }

    public virtual void move()
    {
        Vector3 tempPos = pos;
        tempPos.y -= speed * Time.deltaTime;
        //tempPos.x += speed * Time.deltaTime;
        pos = tempPos;
    }

    public Vector3 pos
    {
        get
        {
            return this.transform.position;
        }
        set
        {
            this.transform.position = value;
        }
    }


}
