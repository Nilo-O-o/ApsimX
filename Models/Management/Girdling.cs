using System;
using Models.Core;


namespace Models;

/// <summary>This model is responsible for girdling practices.</summary>
[Serializable]
[ValidParent(ParentType = typeof(Zone))]
public class Girdling : Model
{

    /// <summary>Invoked whenever girdling happens.</summary>
    public event EventHandler<EventArgs> Girdled;

    /// <summary>Do girdling.</summary>
    public void Apply()
    {
        Girdled?.Invoke(this, new EventArgs());

    }
}