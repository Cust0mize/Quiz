using System.Collections.Generic;
using Game.Quiz.Scripts;
using System.Linq;
using UnityEngine;

public class QuizPanelModel {
    public string QuestionText { get; }
    public int LevelIndex { get; }
    public Sprite Sprite { get; }
    public AnswerModel[] AnswerModels { get; }

    public QuizPanelModel(
    string questionText,
    int levelIndex,
    Sprite sprite,
    AnswerModel[] answerModels
    ) {
        QuestionText = questionText;
        LevelIndex = levelIndex;
        Sprite = sprite;
        AnswerModels = answerModels;
    }
}

public static class QuizElementPanelModelGenerator {
    public static QuizPanelModel GetQuizElementModelByConfig(QuizElementConfig quizElementConfig, int index) {
        AnswerModel[] answerModels = GetAnswerModelByAnswer(quizElementConfig.Answers).ToArray();
        return new QuizPanelModel(quizElementConfig.QuestionText, index, quizElementConfig.QuestionSprite, answerModels);
    }

    private static IEnumerable<AnswerModel> GetAnswerModelByAnswer(string[] answers) {
        for (int i = 0; i < answers.Length; i++) {
            bool isCorrect = i == 0;
            yield return new AnswerModel(answers[i], isCorrect);
        }
    }
}