using System;
using System.Collections.Generic;
using System.Linq;
using Models.Core;
using Models.Core.ApsimFile;
using Models.Soils;

namespace Models;

/// <summary>This model is responsible for applying fertiliser.</summary>
[Serializable]
[ValidParent(ParentType = typeof(Zone))]
public class AgriChemical : Model
{

    /// <summary>Invoked whenever fertiliser is applied.</summary>
    public event EventHandler<EventArgs> Sprayed;

    /// <summary>Apply chemical.</summary>
    public void Apply()
    {
    Sprayed?.Invoke(this, new EventArgs());

    }


    
}