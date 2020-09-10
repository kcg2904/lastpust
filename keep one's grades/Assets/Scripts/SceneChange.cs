using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ChangeScene1()
    {
        SceneManager.LoadScene("01.Scene1");
    }
    public void ChangeScene2()
    {
        SceneManager.LoadScene("02.Scene2");
    }  
    public void ChangeScene3()
    {
        SceneManager.LoadScene("03.Scene3");
    } 
    public void ChangeScene4()
    {
        SceneManager.LoadScene("04.Scene4");
    } 
    public void ChangeScene5()
    {
        SceneManager.LoadScene("05.Scene5");
    }
    public void ChangeScene6()
    {
        SceneManager.LoadScene("06.Scene6");
    }
    public void ChangeScene7()
    {
        SceneManager.LoadScene("07.Scene7");
    }  
    public void ChangeScene81()
    {
        SceneManager.LoadScene("08.Scene8-1");
    }
    public void ChangeScene82()
    {
        SceneManager.LoadScene("09.Scene8-2");
    }
    public void ChangeScene83()
    {
        SceneManager.LoadScene("10.Scene8-3");
    }
    public void ChangeScene84()
    {
        SceneManager.LoadScene("11.Scene8-4");
    }
    public void ChangeScene9()
    {
        SceneManager.LoadScene("12.Scene9");
    }
    public void ChangeScene10()
    {
        SceneManager.LoadScene("13.Scene10");
    }
    public void ChangeScene11()
    {
        SceneManager.LoadScene("14.Scene11");
    }
    public void ChangeScene12()
    {
        SceneManager.LoadScene("15.Scene12");
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("버튼눌림");
    }


}
