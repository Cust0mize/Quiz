using Game.Quiz.Scripts;
using UnityEngine;

public class GameEntryPoint : MonoBehaviour {
    [SerializeField] private QuizLevelConfig _quizLevelConfig;
    [SerializeField] private QuizPanel _quizPanel;

    public void Start() {
        int randomLevelIndex = Random.Range(0, _quizLevelConfig.QuizElementConfigsCount);
        QuizElementConfig randomLevelConfig = _quizLevelConfig.GetElementByIndex(randomLevelIndex);
        QuizPanelModel levelPanelModel = QuizElementPanelModelGenerator.GetQuizElementModelByConfig(randomLevelConfig, randomLevelIndex);
        _quizPanel.Init(levelPanelModel);
    }
}

//Написать логику по загрузке уровня и инициализации панели этим уровнем
//Уровень надо получать рандомно из конфига