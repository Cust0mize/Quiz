using System.Collections.Generic;
using Game.Quiz.Scripts;
using System.Linq;
using UnityEngine;

public class QuizPanelModel {
    public string AnswerText { get; }
    public int LevelIndex { get; }
    public Sprite Sprite { get; }
    public AnswerModel[] AnswerModels { get; }

    public QuizPanelModel(
    string answerText,
    int levelIndex,
    Sprite sprite,
    AnswerModel[] answerModels
    ) {
        AnswerText = answerText;
        LevelIndex = levelIndex;
        Sprite = sprite;
        AnswerModels = answerModels;
    }
}


//Написать класс который будет создавать QuizPanelModel на основе конфига