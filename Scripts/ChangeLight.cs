using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLight : MonoBehaviour
{

    //void OnEnable()
    //{
    //    EventManager.onClicked += changeLight;
    //}

    //void OnDisable()
    //{
    //    EventManager.onClicked -= changeLight;
    //}
    public float time;
    public int increment = 7;

    void changeLight()
    {
        if (gameObject.GetComponent<Renderer>().material.color == Color.red)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    public void onClick()
    {
        if (gameObject.GetComponent<Renderer>().material.color == Color.red)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        time = 0.0f;
        gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (Math.Floor(time)%increment == 0)
        {
            changeLight();
            time = 1.1f;
        }
    }

}
