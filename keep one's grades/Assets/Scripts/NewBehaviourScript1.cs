using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public GameObject ob1;
    public GameObject ob2;

    private bool a = false;

    // Start is called before the first frame update
    void Start()
    {
        ob1.SetActive(false);
        ob2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (a == false)
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
            {
                ob1.SetActive(true);
                a = true;
            }
        }else
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return)) {
                ob2.SetActive(true);
            }
        }
    }
}
