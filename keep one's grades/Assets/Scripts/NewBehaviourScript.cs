using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private float lt = 20;
    public Text tt;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        lt -= Time.deltaTime;
        tt.text = string.Format("{0:N0}" ,lt) + "초";

        if (lt <= 0)
        {
            SceneManager.LoadScene("15.Scene12");
        }
    }
}
