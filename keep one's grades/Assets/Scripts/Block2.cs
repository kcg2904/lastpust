using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block2 : MonoBehaviour
{
    private Vector2 a;
    private bool moveok = false;
    private bool d = false;
    
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "qur")
        {
            Destroy(this.gameObject);
        }
        else if (col.gameObject.tag == "sleep")
        {
            Destroy(this.gameObject);
        }
        else if (col.gameObject.tag == "Player")
        {
            moveok = true;
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
                    this.transform.Translate(new Vector3(0, -46.56000096f));
                    moveok = false;
                }
                else if (Input.GetKey(KeyCode.UpArrow))
                {
                    a = this.transform.localPosition;
                    this.transform.Translate(new Vector3(0, 46.56000096f));
                    moveok = false;
                }
                else if (Input.GetKey(KeyCode.LeftArrow))
                {
                    a = this.transform.localPosition;
                    this.transform.Translate(new Vector3(-54.5439986f, 0));
                    moveok = false;
                }
                else if (Input.GetKey(KeyCode.RightArrow))
                {
                    a = this.transform.localPosition;
                    this.transform.Translate(new Vector3(54.5439986f, 0));
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