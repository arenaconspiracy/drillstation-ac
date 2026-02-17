using Robust.Shared.Serialization;
using Robust.Shared.GameStates;

namespace Content.Shared._Drill.Drill.Components;

/// <summary>
/// The body of the Drill
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class DrillBodyComponent : Component
{
    /// <summary>
    /// Does this body tile count as a core
    /// </summary>
    [DataField("isCore"), AutoNetworkedField]
    [ViewVariables(VVAccess.ReadOnly)]
    public bool IsCore = false;
}

[Serializable, NetSerializable]
public enum DrillBodyVisuals
{
    Core,
    CoreState
}
