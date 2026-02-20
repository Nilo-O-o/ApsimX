using System;
using Models.Core;


namespace Models;

/// <summary>This model is responsible for applying chemical.</summary>
[Serializable]
[ValidParent(ParentType = typeof(Zone))]
public class AgriChemical : Model
{

    /// <summary>Invoked whenever chemical is applied.</summary>
    public event EventHandler<EventArgs> Sprayed;

    /// <summary>Invoked when spray effect ends.</summary>
    public event EventHandler<EventArgs> SprayEnded;

    /// <summary>Apply chemical.</summary>
    public void Apply()
    {
    Sprayed?.Invoke(this, new EventArgs());

    }

    /// <summary>End spray effect (revert to pre-spray state).</summary>
    public void EndSpray()
    {
    SprayEnded?.Invoke(this, new EventArgs());
    }

}