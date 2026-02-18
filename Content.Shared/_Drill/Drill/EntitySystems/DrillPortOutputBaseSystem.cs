using Robust.Shared.Timing;

using Content.Shared._Drill.Drill.Components;

namespace Content.Shared._Drill.Drill.EntitySystems;

public abstract class DrillPortOutputBaseSystem : EntitySystem
{

    public override void Update(float frameTime)
    {
        base.Update(frameTime);
    }

    ///<summary>
    /// Simple wrapper function you override to include your actual output needs
    ///</summary>
    public void DoOutput()
    {
    }
}
