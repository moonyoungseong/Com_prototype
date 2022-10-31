using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class red_control : MonoBehaviour
{
    public List<GameObject> list = new List<GameObject>();
    public List<SpriteRenderer> progress = new List<SpriteRenderer>();
    public GameObject goprogress;
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
        progress[0].color = new Color(0.3f, 0.4f, 0.7f);
    }

    public void Second_Next()
    {
        list[1].SetActive(false);
        list[2].SetActive(true);
        progress[1].color = new Color(0.3f, 0.4f, 0.7f);
    }

    public void third_Next()
    {
        list[2].SetActive(false);
        finishbtn.SetActive(true);
        Title.SetActive(false);
        progress[2].color = new Color(0.3f, 0.4f, 0.7f);
        goprogress.SetActive(false);
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

