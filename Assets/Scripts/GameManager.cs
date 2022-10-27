using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    LevelLoader levelLoader;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        levelLoader = FindObjectOfType<LevelLoader>();
    }
    public void Finished()
    {
        Debug.Log("Finished");
        //open UI
    }
}
