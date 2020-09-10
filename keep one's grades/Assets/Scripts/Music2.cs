using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Music2 : MonoBehaviour
{ 
    private Vector3 a;
    private Vector3 b;
    private bool moveok = false;
    private bool d = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "qur")
        {
            d = true;
        }
        else if (col.gameObject.tag == "music1")
        {
            d = true;
        }
        else if (col.gameObject.tag == "boss")
        {
            d = true;
        }
        else if (col.gameObject.tag == "Player")
        {
            moveok = true;
        }
        else if (col.gameObject.tag == "key")
        {
            d = true;
        }else if (col.gameObject.tag == "door")
        {
            d = true;
        }

    }
    void Start()
    {
        a = this.transform.localPosition;
    }
    void Update()
    {
        if (moveok == true)
        {
            {
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    a = this.transform.localPosition;
                    this.transform.Translate(new Vector3(0, -60.45000465f));
                    moveok = false;

                }
                else if (Input.GetKey(KeyCode.UpArrow))
                {
                    a = this.transform.localPosition;
                    this.transform.Translate(new Vector3(0, 60.45000465f));
                    moveok = false;

                }
                else if (Input.GetKey(KeyCode.LeftArrow))
                {
                    a = this.transform.localPosition;
                    this.transform.Translate(new Vector3(-56, 0));
                    moveok = false;

                }
                else if (Input.GetKey(KeyCode.RightArrow))
                {
                    a = this.transform.localPosition;
                    this.transform.Translate(new Vector3(56, 0));
                    moveok = false;
                }
            }
        }
        if (d == true)
        {
            transform.localPosition = a;
            d = false;
        }
    }
}
