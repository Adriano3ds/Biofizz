using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Biofizz
{
    public class GameMode
    {
        private string _name;
        private GameModeType _type;
        private float _maxPoints;
        private Action _correctAnswerAction, _wrongAnswerAction, _scoreUpAction, _scoreDownAction, _showScoreAction, _gameOverAction, _startUpAction;

        public GameMode()
        {
            _correctAnswerAction = new EmptyAction();
            _wrongAnswerAction = new EmptyAction();
            _scoreUpAction = new EmptyAction();
            _scoreDownAction = new EmptyAction();
            _showScoreAction = new EmptyAction();
            _gameOverAction = new EmptyAction();
            _startUpAction = new EmptyAction();
        }

        public string Name { get => _name; set => _name = value; }

        public float MaxPoints { get => _maxPoints; set => _maxPoints = value; }

        public GameModeType GMType { get => _type; set => _type = value; }

        public Action CorrectAnswerAction { get => _correctAnswerAction; set => _correctAnswerAction = value; }
        public Action WrongAnswerAction { get => _wrongAnswerAction; set => _wrongAnswerAction = value; }
        public Action ScoreUpAction { get => _scoreUpAction; set => _scoreUpAction = value; }
        public Action ScoreDownAction { get => _scoreDownAction; set => _scoreDownAction = value; }
        public Action ShowScoreAction { get => _showScoreAction; set => _showScoreAction = value; }
        public Action GameOverAction { get => _gameOverAction; set => _gameOverAction = value; }
        public Action StartUpAction { get => _startUpAction; set => _startUpAction = value; }

        public bool HasMaxPoints(Player p)
        {
            return p.Score >= MaxPoints;
        }

    }

    public enum GameModeType
    {
        RACEMODE,
        TIMEDMODE
    }

    public class GameModeBuilder
    {
        GameMode gm;
        public GameModeBuilder()
        {
            gm = new GameMode();
        }

        public GameModeBuilder SetName(string name)
        {
            gm.Name = name;
            return this;
        }

        public GameModeBuilder SetGMType(GameModeType type)
        {
            gm.GMType = type;
            return this;
        }

        public GameModeBuilder SetMaxPoints(float points)
        {
            gm.MaxPoints = points;
            return this;
        }

        public GameModeBuilder SetCorrectAnswerAction(Action action)
        {
            gm.CorrectAnswerAction = action;
            return this;
        }

        public GameModeBuilder SetWrongAnswerAction(Action action)
        {
            gm.WrongAnswerAction = action;
            return this;
        }

        public GameModeBuilder SetScoreUpAction(Action action)
        {
            gm.ScoreUpAction = action;
            return this;
        }

        public GameModeBuilder SetScoreDownAction(Action action)
        {
            gm.ScoreDownAction = action;
            return this;
        }

        public GameModeBuilder SetShowScoreAction(Action action)
        {
            gm.ShowScoreAction = action;
            return this;
        }

        public GameModeBuilder SetGameOverAction(Action action)
        {
            gm.GameOverAction = action;
            return this;
        }

        public GameModeBuilder SetStartUpAction(Action action)
        {
            gm.StartUpAction = action;
            return this;
        }

        public GameMode Build()
        {
            return gm;
        }
    }

}
