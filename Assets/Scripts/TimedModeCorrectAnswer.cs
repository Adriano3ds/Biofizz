using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Biofizz
{
    namespace TimedMode
    {
        public class CorrectAnswer : Action
        {

            public void ExecuteAction()
            {
                throw new System.NotImplementedException();
            }

            public void ExecuteAction(Player player)
            {
                player.AddScore(QuestionsManager.currentQuestion.GetDifficulty());
                StartUp.time = 16;
                player.Trigger();
                QuestionsManager.GetQuestion();
                GameModeManager.paused = false;
            }

            public void ExecuteAction(GameObject gameObject)
            {
                throw new System.NotImplementedException();
            }
        }
    }

}