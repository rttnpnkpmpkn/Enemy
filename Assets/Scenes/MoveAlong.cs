using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAlong : MonoBehaviour
{
    private CountItHigher cih;

    // Start is called before the first frame update
    void Start()
    {
        cih = this.gameObject.GetComponent<CountItHigher>();
        {
            if (cih == null)
            {
                Debug.LogWarning("No CountItHigher component on GameOject" + name);
            }
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (cih == null) return;
        float tX = cih.currentNum / 100f;
        Vector3 tempLoc = pos;
        tempLoc.x = tX;
        tempLoc.y = cih.currentNum / 100f;
        tempLoc.z = cih.currentNum / 100f;

        pos = tempLoc;
    }

    public Vector3 pos
    {
        get
        {
            return (transform.position);
        }
        set
        {
            transform.position = value;
        }
    }
}
