using System.ComponentModel.DataAnnotations;
using System;

namespace DojoSurveyValidations.Models
{
    public class Dojo
    {
        // Name, DojoLocation, FavLang, Comment
        [Required]
        [MinLength(2, ErrorMessage="You NEED at leat 2 letters")]
        public string Name {get;set;}

        [Required]
        [Display(Name="Dojo Location")]
        public string DojoLocation {get;set;}

        [Required]
        [Display(Name="Favorate Language")]
        public string FavLang {get;set;}

        [Display(Name="Comment (optional)")]
        [StringLength(20, ErrorMessage="No More Than 20 Letters Please!")]
        public string Comment {get;set;}

    }

}