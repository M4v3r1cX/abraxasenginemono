using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
using abraxasengine2mono.states;

namespace abraxasengine2mono.engine;

public class GameStateManager
{
    private readonly List<GameState> stateList;
    private int currentState;

    public static readonly int MENU = 0;
    public static readonly int CUTSCENE1 = 1;
    public static readonly int RAYCAST = 2;

    /*public GameStateManager()
    {
        stateList = new List<GameState>();
        currentState = MENU;
    }

    public void SetState(int state)
    {
        currentState = state;
        stateList[state].Initialize();
    }

    public void Update()
    {
        stateList[currentState].Update();
    }

    public void LoadContent()
    {
        stateList[currentState].LoadContent();
    }

    public void Draw()
    {
        stateList[currentState].Draw();
    }*/
}
