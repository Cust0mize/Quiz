using UnityEngine.UI;
using UnityEngine;
using System;
using TMPro;

public class QuizPanel : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI _levelLabelTextUI;
    [SerializeField] private TextMeshProUGUI _quizQuestionTextUI;
    [SerializeField] private Image _questionImageUI;
    [SerializeField] private AnswerPanel _answerPanel;

    private Action<bool> _onSelectAnswer;

    public void Init(QuizPanelModel quizPanelModel, Action<bool> onSelectAnswer) {
        _onSelectAnswer = onSelectAnswer;
        _levelLabelTextUI.text = $"Level {quizPanelModel.LevelIndex}";
        _quizQuestionTextUI.text = quizPanelModel.QuestionText;
        _questionImageUI.sprite = quizPanelModel.Sprite;
        _answerPanel.Init(quizPanelModel.AnswerModels, _onSelectAnswer);
    }

    public void DisablePanel() {
        _onSelectAnswer = null;
        _answerPanel.DisableButton();
    }
}