using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManger : MonoBehaviour
{
    public float restarDelay = 2f;
    bool gamehasEnded=false;

    public GameObject completelevel1UI;
    public void Completgame()
    {
        completelevel1UI.SetActive(true);
        
    }
    public void Endgame()
    {
        
        if (gamehasEnded == false)
        {
            gamehasEnded = true;
            Debug.Log("game over");
            
            Invoke("Restart", restarDelay);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
