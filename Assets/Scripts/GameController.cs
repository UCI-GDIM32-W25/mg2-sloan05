using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour

{
    [SerializeField] private Text _scoreText;

    private int _score = 0;

    // Start is called before the first frame update
    void Start()
    {
       UpdateScoreUI();
    }

    public void AddPoint()
    {
        _score++;
        UpdateScoreUI();
    }

    // Update is called once per frame
    private void UpdateScoreUI()
    {
        if(_scoreText != null)
        _scoreText.text = "Points: " + _score;
    }
}
