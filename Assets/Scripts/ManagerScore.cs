using UnityEngine;
using UnityEngine.UI;


public class ManagerScore : MonoBehaviour
{
    public static ManagerScore Instance;
    
    public Text namePlusScore;
    public int highScore;

    private void Awake()
    {
        LoadScore();
        Instance = this;
    }

    public void UpdateHighScore()
    {
        namePlusScore.text = SaveName.Instance.refInputName + " " + MainManager.Instance.m_Points;
        highScore += MainManager.Instance.m_Points;
    }
    private void LoadScore()
    {
        highScore = PlayerPrefs.GetInt("DatahighScore", highScore);
        namePlusScore.text = SaveName.Instance.refInputName + " " + highScore;
    }

    private void SaveScore()
    {        
        PlayerPrefs.SetInt("highScore", highScore);
    }
    private void OnApplicationFocus(bool focus)
    {
        if (!focus)
        {
            UpdateHighScore();
            SaveScore();
        }
    }
}
