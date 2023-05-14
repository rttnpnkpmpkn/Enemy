using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountItHigher : MonoBehaviour
{
    // Start is called before the first frame update
    private int _num = 0;

    // Update is called once per frame
    void Update()
    {
        Debug.Log("The next num is: " + nextNum);
    }

    public int nextNum
    {
        get
        {
            _num++;
            return _num;
        }
    }

    public int currentNum
    {
        get
        {
            return _num;
        }
        set
        {
            _num = value;
        }
    }
}
