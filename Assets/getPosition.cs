using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getPosition : MonoBehaviour
{
    public GameObject cube;
    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;
    public Light light5;
    public Light light6;
    public Light light7;
    public bool isTilted = false;
    public bool changeLights = false;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("getPos", 0f, 0.3f);
    }

    // Update is called once per frame
    void getPos()
    {
        if (!isTilted &&
            cube.transform.localEulerAngles.x >= 90 ||
            cube.transform.localEulerAngles.x <= -90) {
            isTilted = true;
        }

        if (isTilted &&
            cube.transform.localEulerAngles.x < 90 ||
            cube.transform.localEulerAngles.x > -90) {
            if (changeLights) {
                light1.color = Color.white;
                light2.color = Color.white;
                light3.color = Color.white;
                light4.color = Color.white;
                light5.color = Color.white;
                light6.color = Color.white;
                light7.color = Color.white;
                changeLights = false;
            } else {
                light1.color = Color.blue;
                light2.color = Color.blue;
                light3.color = Color.blue;
                light4.color = Color.blue;
                light5.color = Color.blue;
                light6.color = Color.blue;
                light7.color = Color.blue;
                changeLights = true;
            }
            isTilted = false;
        }
    }
}
