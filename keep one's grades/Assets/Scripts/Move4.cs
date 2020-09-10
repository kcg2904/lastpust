using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Move4 : MonoBehaviour
{
    private Vector3 a;
    [SerializeField] GameObject ob1;
    private Animator ani;
    private bool b = false;
    private bool key = false;
    private bool block1 = false;
    private bool music1 = false;
    private int count = 24;
    [SerializeField] private Text count_text;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (key == true)
        {
            Destroy(ob1);
        }
        if (count >= 0)
        {
            PlayerMove();
        }
        else
        {
            SceneManager.LoadScene("07.Scene7");
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "qur")
        {
            b = true;
            count += 1;
            count_text.text = count.ToString();
        }
        if (col.gameObject.tag == "key")
        {
            key = true;
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "door")
        {
            if (key == false)
            {
                count += 1;
                count_text.text = count.ToString();
                b = true;
            }
        }
        if (col.gameObject.tag == "block")
        {
            transform.localPosition = a;
            block1 = true;
        }
        if (col.gameObject.tag == "music1")
        {
            transform.localPosition = a;
            music1 = true;
        }
        if (col.gameObject.tag == "sleep")
        {
            count -= 1;
            count_text.text = count.ToString();
        }
        if (col.gameObject.tag == "clear")
        {
            SceneManager.LoadScene("11.Scene8-4");
        }
    }
    void obmove()
    {
        if (block1 == true)
        {
            ani.SetTrigger("kick");
            transform.localPosition = a;
            count += 1;
            count_text.text = count.ToString();
            block1 = false;
            ani.SetTrigger("idle");
        }
        else if (music1 == true)
        {
            ani.SetTrigger("kick");
            transform.localPosition = a;
            count += 1;
            count_text.text = count.ToString();
            music1 = false;
            ani.SetTrigger("idle");
        }
    }
    void PlayerMove()
    {
        if (b)
        {
            Remove();
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                a = this.transform.localPosition;
                transform.Translate(new Vector2(0, 60.45000465f));
                count -= 1;
                count_text.text = count.ToString();
                obmove();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                a = this.transform.localPosition;
                transform.Translate(new Vector2(0, -60.45000465f));
                count -= 1;
                count_text.text = count.ToString();
                obmove();
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                a = this.transform.localPosition;
                transform.Translate(new Vector2(56, 0));
                count -= 1;
                count_text.text = count.ToString();
                obmove();
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                a = this.transform.localPosition;
                transform.Translate(new Vector2(-56, 0));
                count -= 1;
                count_text.text = count.ToString();
                obmove();
            }
        }
    }
    void Remove()
    {
        transform.localPosition = a;
        a = new Vector3(0, 0, 0);
        b = false;
    }
}
