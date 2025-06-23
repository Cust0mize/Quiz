using Game.Quiz.Scripts;
using UnityEngine;
using System;

public class GameEntryPoint : MonoBehaviour {
    [SerializeField] private QuizLevelConfig _quizLevelConfig;
    [SerializeField] private QuizPanel _quizPanel;
    private int _levelIndex;

    public void Start() {
        CreateLevel();
    }

    private void CreateLevel() {
        QuizElementConfig randomLevelConfig = _quizLevelConfig.GetElementByIndex(_levelIndex);
        QuizPanelModel levelPanelModel = QuizElementPanelModelGenerator.GetQuizElementModelByConfig(randomLevelConfig, _levelIndex);
        Action<bool> onPanelClick = null;
        onPanelClick += AnswerHandle;
        _quizPanel.Init(levelPanelModel, onPanelClick);
    }

    private void AnswerHandle(bool isCorrect) {
        _quizPanel.DisablePanel();

        if (_levelIndex >= _quizLevelConfig.QuizElementConfigsCount - 1) {
            Debug.Log("End level");
        }
        else {
            _levelIndex++;
        }

        CreateLevel();
    }
}