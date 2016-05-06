using System;
using System.ComponentModel.DataAnnotations;

namespace TrainApplication.Database
{
    [MetadataType(typeof(RouteMetadata))]
    public partial class Route
    {
    }

    public partial class RouteMetadata
    {
        [Required(ErrorMessage = "Please enter : Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Train")]
        public int TraindId { get; set; }

        [Display(Name = "Destination")]
        public int DestinationId { get; set; }

        [Display(Name = "DateStart")]
        public DateTime DateStart { get; set; }

        [Display(Name = "DateEnd")]
        public DateTime DateEnd { get; set; }

        [Display(Name = "Distination")]
        public Distination Distination { get; set; }

        [Display(Name = "Purchases")]
        public Purchase Purchases { get; set; }

        [Display(Name = "Train")]
        public Train Train { get; set; }

    }
}
