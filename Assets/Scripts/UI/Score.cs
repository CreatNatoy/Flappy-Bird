using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _score;
    [SerializeField] private TMP_Text _maxScore;
    [SerializeField] private GameObject _gameObjectScore;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("Score"))
            PlayerPrefs.SetInt("Score", 0);

      
        _maxScore.text = PlayerPrefs.GetInt("Score").ToString();
        _gameObjectScore.SetActive(true); 
    }

    private void OnEnable()
    {
        _player.ScoreChanged += OnScoreChanged; 
    }

    private void OnDisable()
    {
        _player.ScoreChanged -= OnScoreChanged; 
    }

    private void OnScoreChanged(int score)
    {
        _score.text = score.ToString(); 
    }

    public void CheckScore(bool star)
    {
        _maxScore.text = PlayerPrefs.GetInt("Score").ToString();
        _gameObjectScore.SetActive(star);
    }

    public void DeleteKey()
    {
        PlayerPrefs.DeleteKey("Score"); 
    }
}
