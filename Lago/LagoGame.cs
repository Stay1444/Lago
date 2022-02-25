using Lago.Engine;
using Lago.Engine.Game;
using Lago.Engine.Rendering;

namespace Lago;

public abstract class LagoGame
{
    protected abstract void Update(UpdateContext context);
    protected abstract void Render(RenderContext context);
    protected virtual void OnLoad() { }
    protected virtual void OnUnload() { }
    protected LagoGame()
    {
        
    }

    public void Run()
    {
        this.OnLoad();
    }
    
    public void Stop()
    {
        this.OnUnload();   
    }
    
    
}
