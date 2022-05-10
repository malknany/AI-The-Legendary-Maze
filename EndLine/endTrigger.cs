using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public gameManger gamemanger;
    void OnTriggerEnter()
    {
        gamemanger.Completgame();
    }
}
