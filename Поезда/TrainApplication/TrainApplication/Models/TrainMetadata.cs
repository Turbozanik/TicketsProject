using System;
using System.ComponentModel.DataAnnotations;

namespace TrainApplication.Database
{
    [MetadataType(typeof(TrainMetadata))]
    public partial class Train
    {
    }

    public partial class TrainMetadata
    {
        [Required(ErrorMessage = "Please enter : Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "GovId")]
        public string GovId { get; set; }

        [Display(Name = "Capacity")]
        public int Capacity { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Routes")]
        public Route Routes { get; set; }

    }
}
