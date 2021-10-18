using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(PlayerMover))]
public class Player : MonoBehaviour
{
    [SerializeField] private MusicEffectors _musicEffectors;
    public InterAd _interAd; // reklama

    private PlayerMover _mover;
    private int _score;

    public event UnityAction GameOver;
    public event UnityAction<int> ScoreChanged; 

    private void Start()
    {
        _mover = GetComponent<PlayerMover>();
    }

    public void IncreateScore()
    {
        _score++;
        ScoreChanged?.Invoke(_score); 
    }

    public void ResetPlayer()
    {
        _score = 0;
        ScoreChanged?.Invoke(_score);
        _mover.ResetGame();
    }

    public void Die()
    {
        if(PlayerPrefs.GetInt("Score") < _score)
            PlayerPrefs.SetInt("Score", _score);
        GameOver?.Invoke();
        _musicEffectors.PlayDieSound();
        _interAd.ShowAd(); 
    }
}
