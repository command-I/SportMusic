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
    
    public partial class Tracks
    {
        public int id { get; set; }
        public int downloader { get; set; }
        public string artist { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public string mood { get; set; }
        public int bitrate { get; set; }
        public string source { get; set; }
        public string path { get; set; }
        public System.TimeSpan duration { get; set; }
        public byte[] date_add { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
