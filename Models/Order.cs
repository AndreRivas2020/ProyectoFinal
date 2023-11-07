using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcMusicStore.Models
{
[Bind(Exclude = "OrderId")]
public partial class Order
{
[ScaffoldColumn(false)]
public int OrderId { get; set; }
[ScaffoldColumn(false)]
public System.DateTime OrderDate { get; set; }
[ScaffoldColumn(false)]
public string Username { get; set; }
[Required(ErrorMessage = "Primer nombre es requerido")]
[DisplayName("Primer nombre")] [StringLength(160)]
public string FirstName { get; set; }
[Required(ErrorMessage = "Apellido es requerido")]
[DisplayName("Apellido")]
[StringLength(160)]
public string LastName { get; set; }
[Required(ErrorMessage = "Dirección es requerida")]
[StringLength(70)]
public string Direccion { get; set; }
[Required(ErrorMessage = "Ciudad es requerida")]
[StringLength(40)]
public string Ciudad { get; set; }
[Required(ErrorMessage = "Estado es requerido")]
[StringLength(40)]
public string Estado { get; set; }
[Required(ErrorMessage = "Código postal es requerido")]
[DisplayName("Código Postal")]
[StringLength(10)]
public string Postal { get; set; }
[Required(ErrorMessage = "País es requerido")]
[StringLength(40)]
public string País { get; set; }
[Required(ErrorMessage = "Teléfono es requerido")]
[StringLength(24)]
public string Teléfono { get; set; }
[Required(ErrorMessage = "Correo electrónico es requerido")]
[DisplayName("Correo electrónico")]
[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
ErrorMessage = "Correo no es válido.")]
[DataType(DataType.EmailAddress)]
public string Email { get; set; }
[ScaffoldColumn(false)]
public decimal Total { get; set; }
public List<OrderDetail> OrderDetails { get; set; }
}
}