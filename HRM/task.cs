
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
    
public partial class task
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public task()
    {

        this.employees = new HashSet<employees>();

    }


    public int id { get; set; }

    public string task1 { get; set; }

    public Nullable<System.DateTime> start_time { get; set; }

    public Nullable<System.DateTime> end_time { get; set; }

    public string accomplishment { get; set; }

    public Nullable<int> id_sotrud { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<employees> employees { get; set; }

    public virtual employees employees1 { get; set; }

}

}
