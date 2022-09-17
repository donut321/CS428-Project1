using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getPosition : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("getPos", 0f, 0.5f);
    }

    // Update is called once per frame
    void getPos()
    {
        Debug.Log(cube.transform.position);
    }
}
