using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] GameObject finishCanvas;
    public int coins;
    public Text coinText;
    public bool isFinished;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            transform.parent = null;
            isFinished = false;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }
    private void Start()
    {
        coinText.text = coins.ToString();
        finishCanvas.SetActive(false);
    }
    public void Finished()
    {
        finishCanvas.SetActive(true);
        isFinished = true;
    }
    public void LoadNext()
    {
        LevelLoader.Instance.NextLevel();
        finishCanvas.SetActive(false);
        isFinished = false;
    }
    public void AddCoin()
    {
        coins++;
        coinText.text = coins.ToString();
    }
}
