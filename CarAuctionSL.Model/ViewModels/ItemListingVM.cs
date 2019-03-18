using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAuctionSL.Model.ViewModels
{
    public class ItemListingVM
    {

        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Code value.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the DisplayName value.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the MakeId value.
        /// </summary>
        public int MakeId { get; set; }

        /// <summary>
        /// Gets or sets the Make value.
        /// </summary>
        public string Make { get; set; }

        /// <summary>
        /// Gets or sets the ModelId value.
        /// </summary>
        public int ModelId { get; set; }

        /// <summary>
        /// Gets or sets the Model value.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets the MilageId value.
        /// </summary>
        public int MilageId { get; set; }

        /// <summary>
        /// Gets or sets the Milage value.
        /// </summary>
        public string Milage { get; set; }

        /// <summary>
        /// Gets or sets the Year value.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets the YearName value.
        /// </summary>
        public string YearName { get; set; }

        /// <summary>
        /// Gets or sets the EngineCapacity value.
        /// </summary>
        public int EngineCapacity { get; set; }

        /// <summary>
        /// Gets or sets the Transmission value.
        /// </summary>
        public string Transmission { get; set; }

        /// <summary>
        /// Gets or sets the FuelTyoe value.
        /// </summary>
        public string FuelTyoe { get; set; }

        /// <summary>
        /// Gets or sets the DoorCount value.
        /// </summary>
        public int DoorCount { get; set; }

        /// <summary>
        /// Gets or sets the SellingPrice value.
        /// </summary>
        public decimal SellingPrice { get; set; }

        /// <summary>
        /// Gets or sets the IsValuationDone value.
        /// </summary>
        public bool IsValuationDone { get; set; }

    }
}
