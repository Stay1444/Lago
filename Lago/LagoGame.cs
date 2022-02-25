using Lago.Engine;
using Lago.Engine.Game;
using Lago.Engine.Rendering;

namespace Lago;

public abstract class LagoGame
{
    public abstract void Update(UpdateContext context);
    public abstract void Render(RenderContext context);
    
    protected LagoGame(UpdateContext context)
    {
        
    }
    
    
}
