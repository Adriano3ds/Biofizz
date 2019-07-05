using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Biofizz;

public static class GameModeManager
{
    public static Camera camera;
    static GameMode currentGameMode;
    public static GameObject canvas, gameOverCanvas;
    public static IEnumerator toExecute, toExecute2;
    public static bool paused = false;

    public static class GameModes
    {
        //20.52
        public static readonly GameMode Race = (new GameModeBuilder()).SetName("RaceMode")
            .SetGMType(GameModeType.RACEMODE).SetMaxPoints(20.52f)
            .SetCorrectAnswerAction(new Biofizz.RaceMode.CorrectAnswer())
            .SetWrongAnswerAction(new Biofizz.RaceMode.WrongAnswer())
            .SetGameOverAction(new Biofizz.RaceMode.GameOver())
            .SetShowScoreAction(new Biofizz.RaceMode.ShowScore()).Build();
        public static readonly GameMode Timed = (new GameModeBuilder()).SetName("TimedMode")
            .SetGMType(GameModeType.TIMEDMODE).SetMaxPoints(10000f)
            .SetCorrectAnswerAction(new Biofizz.TimedMode.CorrectAnswer())
            .SetWrongAnswerAction(new Biofizz.TimedMode.WrongAnswer())
            .SetStartUpAction(new Biofizz.TimedMode.StartUp())
            .SetGameOverAction(new Biofizz.TimedMode.GameOver())
            .SetShowScoreAction(new Biofizz.TimedMode.ShowScore()).Build();
    }
    public static GameMode GameMode { get => currentGameMode; }

    public static void SetGameMode(GameMode gm)
    {
        currentGameMode = gm;
    }

}
