﻿using System;
using System.ComponentModel.DataAnnotations;

namespace TrainApplication.Database
{
    [MetadataType(typeof (PurchaseMetadata))]
    public partial class Purchase
    {
    }

    public partial class PurchaseMetadata
    {
        [Required(ErrorMessage = "Please enter : Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "User")]
        public string UserId { get; set; }

        [Display(Name = "Route")]
        public int RouteId { get; set; }

        [Display(Name = "DatePurchased")]
        public DateTime DatePurchased { get; set; }
    }
}

