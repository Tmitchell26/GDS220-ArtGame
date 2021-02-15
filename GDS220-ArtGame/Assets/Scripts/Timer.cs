using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Animator francine;
    public Animator medic;
    public Text gameTime;

    public float gameTimer;
    public GameObject speech;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startTimer());
    }

    IEnumerator startTimer()
    {
        gameTimer = 120;

        while (gameTimer > 0)
        {
            gameTimer -= Time.deltaTime;
            gameTime.text = gameTimer.ToString();
            yield return null;
        }

        if (gameTimer <= 0)
        {
            medic.SetBool("Medic", true);
            yield return new WaitForSeconds(3f);
            speech.SetActive(true);
            yield return new WaitForSeconds(3f);

            francine.SetBool("Crying", true);
            yield return new WaitForSeconds(6f);
            SceneManager.LoadScene("EndGame");
        }
    }
}
