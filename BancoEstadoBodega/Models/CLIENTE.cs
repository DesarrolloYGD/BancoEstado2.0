//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BancoEstadoBodega.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTE()
        {
            this.PRODUCTO = new HashSet<PRODUCTO>();
        }
    
        public int IDCliente { get; set; }
        public string Alias { get; set; }
        public string RazonSocial { get; set; }
        public string Rut { get; set; }
        public string CorreoDTE { get; set; }
        public string Giro { get; set; }
        public string Telefono { get; set; }
        public int IDComunaFK { get; set; }
        public string Direccion { get; set; }
    
        public virtual COMUNA COMUNA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTO> PRODUCTO { get; set; }
    }
}
