//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRM
{
    using System;
    using System.Collections.Generic;
    
    public partial class resume
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public resume()
        {
            this.employees = new HashSet<employees>();
        }
    
        public int id { get; set; }
        public string f { get; set; }
        public string i { get; set; }
        public string o { get; set; }
        public string mail { get; set; }
        public Nullable<int> vozract { get; set; }
        public string education { get; set; }
        public string opisanie { get; set; }
        public Nullable<int> id_sotrud { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<employees> employees { get; set; }
        public virtual employees employees1 { get; set; }
    }
}
