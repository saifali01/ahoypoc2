//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AhoyDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Unit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Unit()
        {
            this.Rooms = new HashSet<Room>();
        }
    
        public int ID { get; set; }
        public string UnitName { get; set; }
        public string UnitImage { get; set; }
        public string UnitDescription { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string PriceUnit { get; set; }
        public string Facilities { get; set; }
        public Nullable<decimal> Rating { get; set; }
        public string UnitLocation { get; set; }
        public Nullable<decimal> Lat { get; set; }
        public Nullable<decimal> Long { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Room> Rooms { get; set; }
    }
}