using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Biofizz;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Player p;
    void Start()
    {
        //p = new Player(n, transform);
        //PlayerManager.AddPlayer(p);
        //PlayerManager.SetCurrenPlayer(p);
    }

    // Update is called once per frame
    void Update()
    {
        if (p.Triggered)
        {
            Quiz.currentCoroutine = StartCoroutine(GameModeManager.toExecute);
            if(GameModeManager.toExecute2 != null)
                Quiz.currentCoroutine2 = StartCoroutine(GameModeManager.toExecute2);
            p.Untrigger();
        }
    }
}
