using System.ComponentModel.DataAnnotations;

namespace testeef.Models
{
    public class Product
    {
        [Key]
        public int Id{ get; set;}

        [Required(ErrorMessage= "Este campo é obrigatorio")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres" )]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre e 3 60 caracteres")]
               public string Title { get; set; }

               [MaxLength(1024, ErrorMessage = "Este campo deve conter no maximo 1024 caracteres")]
               public string Description {get; set;}

               [Required(ErrorMessage = "Este campo é obrigatorio")]
               [Range(1, int.MaxValue, ErrorMessage = "O Preço deve ser maior do que zero")]
               public decimal price {get;set;}

               [Required(ErrorMessage = "Este campo é obrigatorio")]
               [Range(1, int.MaxValue, ErrorMessage = "Categorio invalida")]
               public int CategoryId { get; set; }
               public Category Category {get; set;}


    }
}