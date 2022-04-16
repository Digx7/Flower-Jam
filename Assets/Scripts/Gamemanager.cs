using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Gamemanager : MonoBehaviour
{
    [SerializeField]
    private int score;

    public UnityEvent gameStart;
    public UnityEvent gameEnd;

    public void Start(){
      GameStart();
    }

    public void GameStart(){
      gameStart.Invoke();
    }

    public void PlayerLose(){
      GameEnd();
    }

    public void PlayerWin(){
      GameEnd();
    }

    public void GameEnd(){
      gameEnd.Invoke();
    }

    public int GetScore(){
      return score;
    }

    public void SetScore(int input){
      score = input;
    }

    public void UpdateScore(int input){
      score += input;
    }
}
