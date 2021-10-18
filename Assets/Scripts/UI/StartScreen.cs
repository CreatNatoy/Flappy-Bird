using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartScreen : ScreenGame
{
    public event UnityAction PlayButtonClick;

    public override void Close()
    {
        CanvasGroup.alpha = 0;
        Button.interactable = false;
        _gameObjectsScore.CheckScore(false); 
    }

    public override void Open()
    {
        CanvasGroup.alpha = 1;
        Button.interactable = true;
        _gameObjectsScore.CheckScore(true);
    }

    protected override void OnButtonClick()
    {
        PlayButtonClick?.Invoke(); 
    }
}
