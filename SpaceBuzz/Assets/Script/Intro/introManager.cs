using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introManager : MonoBehaviour
{
    private void Start()
    {

        Application.targetFrameRate = 30;

        if (PlayerPrefs.HasKey("HasDoneIntro"))
        {
            //SceneManager.LoadScene("Game");
            StartCoroutine(LoadBase());

        }
        else
        {
            //SceneManager.LoadScene("Tutorial");
            StartCoroutine(LoadIntro());
        }






    }
    IEnumerator LoadIntro()
    {

        yield return new WaitForSecondsRealtime(2);
        SceneManager.LoadScene(1);

    }

    IEnumerator LoadBase()
    {

        yield return new WaitForSecondsRealtime(2);
        SceneManager.LoadScene(2);

    }

    
}


