using System.ComponentModel.DataAnnotations;
namespace Autenticacion.Model
{
	public class User
	{
		[Required] //VErificar que se importo usin System 
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}
