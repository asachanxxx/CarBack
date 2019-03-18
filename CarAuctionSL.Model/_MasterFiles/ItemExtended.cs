using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAuctionSL.Model._MasterFiles
{
    public class ItemExtended
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public bool SecuritySystem { get; set; }
        public bool Airconditioning { get; set; }
        public bool AlloyWheels { get; set; }
        public bool ABS { get; set; }
        public bool Anti_Theft { get; set; }
        public bool Anti_Starter { get; set; }
        public bool ExteriorColor { get; set; }
        public bool InteriorColor { get; set; }
        /// <summary>
        /// Used or New
        /// </summary>
        public string Condition { get; set; }
        public bool FogLights { get; set; }
        public bool RearWindowDefroster { get; set; }
        public bool TintedGlass { get; set; }
        public bool SoundSystem { get; set; }
        public bool CruiseControl { get; set; }
        public bool PowerSteering { get; set; }
        public bool MultifunctionSteering { get; set; }
        public bool PowerWindows { get; set; }
        public bool RearWindowWiper { get; set; }
        public bool TemporarySpareTire { get; set; }
        public bool PassengerVanityMirro { get; set; }
        public bool TirePressureMonitor { get; set; }
        public bool PowerMirror { get; set; }
        public bool RearSpoiler { get; set; }
        public bool BluetoothConnection { get; set; }
        public bool AdjustableSteeringWheel { get; set; }
        public bool TractionControl { get; set; }
        public bool AirbagSide { get; set; }
        public bool AirbagDriver { get; set; }
        public bool AirbagPassenger { get; set; }

    }
}


