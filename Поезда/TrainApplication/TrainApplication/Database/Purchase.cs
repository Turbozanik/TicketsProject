//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrainApplication.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Purchase
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int RouteId { get; set; }
        public System.DateTime DatePurchased { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Route Route { get; set; }
    }
}
