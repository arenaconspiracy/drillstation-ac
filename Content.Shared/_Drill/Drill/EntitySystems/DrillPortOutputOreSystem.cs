using Robust.Shared.Audio;
using Robust.Shared.Timing;
using Robust.Shared.GameObjects;

using Content.Shared._Drill.Drill.Components;

namespace Content.Shared._Drill.Drill.EntitySystems;

public sealed partial class DrillPortOutputOreSystem : EntitySystem
{

    [Dependency] private readonly IGameTiming _timing = default!;

    public override void Update(float frameTime)
    {
        base.Update(frameTime);

        var curTime = _timing.CurTime;
        var query = EntityQueryEnumerator<DrillPortOutputOreComponent>();
        while (query.MoveNext(out var uid, out var port))
        {
            if ((curTime < port.NextOutput) | (!port.IsActive))
                continue;

            port.NextOutput = curTime + port.OutputInterval;
        }
    }

    public void SetActive(EntityUid uid, bool value, DrillPortOutputOreComponent? port = null)
    {
        if (!Resolve(uid, ref port))
            return;
        if (value == port.IsActive)
            return;

        port.IsActive = value;

        Dirty(uid, port);
    }

}
