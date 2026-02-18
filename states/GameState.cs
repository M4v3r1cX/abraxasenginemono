using System;
using abraxasengine2mono.engine;
using Microsoft.Xna.Framework;

namespace abraxasengine2mono.states;

public abstract class GameState
{
    protected GameStateManager gameStateManager;

    public abstract void Initialize();
    public abstract void LoadContent();
    public abstract void Update(GameTime gameTime);
    public abstract void Draw(GameTime gameTime);
}
