//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DreamHome.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class houses
    {
        public int id_house { get; set; }
        public string nameHouse { get; set; }
        public string nameSeller { get; set; }
        public Nullable<int> value { get; set; }
        public string ubication { get; set; }
        public string size { get; set; }
        public Nullable<int> rooms { get; set; }
        public Nullable<int> bathrooms { get; set; }
        public Nullable<int> garages { get; set; }
        public string photoHouse { get; set; }
        public Nullable<bool> active { get; set; }
    }
}
