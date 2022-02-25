using Lago.Engine;
using Lago.Engine.Game;
using Lago.Engine.Rendering;

namespace Lago;

public abstract class LagoGame
{
    protected abstract void Update(UpdateContext context);
    protected abstract void Render(RenderContext context);
    public virtual void OnLoad() { }
    public virtual void OnUnload() { }
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
