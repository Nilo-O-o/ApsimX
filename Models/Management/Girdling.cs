using System;
using System.Collections.Generic;
using System.Linq;
using Models.Core;
using Models.Core.ApsimFile;
using Models.Soils;

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