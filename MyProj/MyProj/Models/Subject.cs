//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyProj.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subject
    {
        public string SubjectID { get; set; }
        public string Subject_name { get; set; }
        public string PulpitID { get; set; }
    
        public virtual Pulpit Pulpit { get; set; }
    }
}
