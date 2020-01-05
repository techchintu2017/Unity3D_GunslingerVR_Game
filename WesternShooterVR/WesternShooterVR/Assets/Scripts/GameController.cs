using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public TextMesh infoText;

    public Bottle[] bottles;

    private float gameTimer = 0f;

    private float resetTimer = 5f;

    void Start()
    {
        
    }

    
    void Update()
    {
        bool won = true;
        foreach (Bottle can in bottles)
        {
            if(can.wasHit == false)
            {
                won = false;
                break;
            }
        }

        if (won == false)
        {
            gameTimer += Time.deltaTime;

            infoText.text = "Shoot all of the Bottles!\nTime: " + Mathf.Floor(gameTimer);
        }
        else
        {
            infoText.text = "Beat Your Time OF: " + Mathf.Floor(gameTimer) + " seconds";

            resetTimer -= Time.deltaTime;
            if(resetTimer <= 0f)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
