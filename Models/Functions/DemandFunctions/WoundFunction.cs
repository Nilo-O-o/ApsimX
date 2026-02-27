using System;
using APSIM.Core;
using Models.Core;
using Models.PMF.Phen;

namespace Models.Functions.DemandFunctions
{
    /// <summary>Returns a value of zero between wounding and complete healing.</summary>
    [Serializable]
    [ViewName("UserInterface.Views.PropertyView")]
    [PresenterName("UserInterface.Presenters.PropertyPresenter")]
    public class WoundFunction : Model, IFunction
    {
        [Link(Type = LinkType.Child, ByName = true)]
        private IFunction target = null;

        [Link(Type = LinkType.Child, ByName = true)]
        private IFunction progression = null;

        /// <summary>The _ value</summary>
        private double _Value = 1;

        /// <summary>Gets the value.</summary>
        public double Value(int arrayIndex = -1)
        {
            if (Healing >= target.Value())
            {
                _Value = 1;
            }
            else
            {
                _Value = 0;
            }

            return _Value;
        }

        /// <summary>
        /// The relative extent of wound healing.
        /// </summary>
        public double Healing {  get; set; }

        /// <summary>
        /// An event to initiate wound.
        /// </summary>
        public void Event()
        {
            Healing = 0;
        }


        [EventSubscribe("StartOfDay")]
        private void OnStartOfDay(object sender, EventArgs args)
        {
            Healing += progression.Value();
        }

        [EventSubscribe("Sowing")]
        private void OnSowing(object sender, EventArgs e)
        {
            _Value = 1;
        }
     }
}



