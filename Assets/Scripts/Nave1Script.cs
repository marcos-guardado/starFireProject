using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Nave1Script : MonoBehaviour
{
    public GameObject nave1;
    public string juegoPrincipal;

    public void SelectNave1()
    {
        PlayerStorage.playerPrefab = nave1;
        this.LoadScene(juegoPrincipal);

    }

    public void LoadScene(string scenename)
    {
        Debug.Log("sceneName to load: " + scenename);
        // SceneManager.LoadScene(scenename);
    }
}
