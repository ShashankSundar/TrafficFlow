using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    public delegate void ClickAction();
    public static event ClickAction OnClicked;

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "Click"))
        {
            if (OnClicked != null)
                OnClicked();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if(hit.transform.tag == "Light")
                {
                    ChangeLight light = hit.transform.GetComponent<ChangeLight>();
                    light.onClick();
                }
                //print("Tag: " + hit.transform.tag);
            }
        }
    }
}
