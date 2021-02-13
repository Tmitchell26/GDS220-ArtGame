using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Animator animator;

    public float gameTimer;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator startTimer()
    {
        gameTimer = 120f;

        while (gameTimer > 0)
        {
            gameTimer -= Time.deltaTime;
            yield return null;
        }

        if (gameTimer <= 0)
        {
            animator.SetBool("Crying", true);
            yield return new WaitForSeconds(5f);
            SceneManager.LoadScene("EndGame");
        }
    }
}
