using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public void UpdateScoreText(int input){
      scoreText.text = "Score: " + input.ToString();
    }
}
