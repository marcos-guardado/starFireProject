using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreValue == 80)
        {
            SceneManager.LoadScene("FinalBoss");
        }

        score.text = "La puntuación es:" + scoreValue;

    }
}
