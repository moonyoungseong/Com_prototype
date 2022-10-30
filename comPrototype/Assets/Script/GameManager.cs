using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Topbutton()
    {
        SceneManager.LoadScene("testProgress");
    }

    void midbutton()
    {
        
    }

    void buttombutton()
    {

    }

    public void Explain()
    {
        SceneManager.LoadScene("testExplanation");
    }

    public void Back()
    {
        SceneManager.LoadScene("testSelect");
    }
}
