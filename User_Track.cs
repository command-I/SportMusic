//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportMusic
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_Track
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User_Track()
        {
            this.Edit_Track = new HashSet<Edit_Track>();
        }
    
        public int id { get; set; }
        public Nullable<int> author { get; set; }
        public int track_id { get; set; }
        public string artist { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public string mood { get; set; }
        public Nullable<int> bitrate { get; set; }
        public string source { get; set; }
        public string path { get; set; }
        public System.TimeSpan duration { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Edit_Track> Edit_Track { get; set; }
        public virtual Users Users { get; set; }
    }
}
