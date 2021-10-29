using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Nave2Script : MonoBehaviour
{
    public GameObject nave2;
    public string juegoPrincipal;
    public void SelectNave2()
    {
        PlayerStorage.playerPrefab = nave2;
        this.LoadScene(juegoPrincipal);
    }

    public void LoadScene(string scenename)
    {
        Debug.Log("sceneName to load: " + scenename);
        SceneManager.LoadScene(scenename);
    }
}
