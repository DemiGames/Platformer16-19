using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int coins;
    public Text coinText;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            transform.parent = null;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }
    private void Start()
    {
        coinText.text = coins.ToString();
    }
    public void Finished()
    {
        Debug.Log("Finished");
        LevelLoader.Instance.NextLevel();
    }
    public void AddCoin()
    {
        coins++;
        coinText.text = coins.ToString();
    }
}
