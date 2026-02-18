using Robust.Shared.Serialization;
using Robust.Shared.GameStates;

namespace Content.Shared._Drill.Drill.Components;

/// <summary>
/// Abstract base for an output port
/// Used for intervals and activity states
/// </summary>
public abstract partial class DrillPortOutputBaseComponent : Component
{
    /// <summary>
    /// The output interval
    /// </summary>
    [DataField("outputInterval"), AutoNetworkedField]
    [ViewVariables(VVAccess.ReadWrite)]
    public TimeSpan OutputInterval = TimeSpan.FromSeconds(10);

    /// <summary>
    /// Is this port currently doing work
    /// </summary>
    [DataField("isActive"), AutoNetworkedField]
    [ViewVariables(VVAccess.ReadOnly)]
    public bool IsActive = false;
}
