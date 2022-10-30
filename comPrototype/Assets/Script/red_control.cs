using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class red_control : MonoBehaviour
{
    public List<GameObject> list = new List<GameObject>();
    public GameObject Title;
    public GameObject finishbtn;
    public GameObject result;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void first_Next()
    {
        list[0].SetActive(false);
        list[1].SetActive(true);
    }

    public void Second_Next()
    {
        list[1].SetActive(false);
        list[2].SetActive(true);
    }

    public void third_Next()
    {
        list[2].SetActive(false);
        finishbtn.SetActive(true);
        Title.SetActive(false);
    }

    public void Finish()
    {
        finishbtn.SetActive(false);
        result.SetActive(true);
    }

    public void ScoreCheck()
    {
        SceneManager.LoadScene("testanswer");
    }

    public void Gohome()
    {
        SceneManager.LoadScene("testSelect");
    }
}

