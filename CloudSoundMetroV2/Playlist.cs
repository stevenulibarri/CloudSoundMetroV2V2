//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CloudSoundMetroV2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Playlist
    {
        public Playlist()
        {
            this.Songs = new HashSet<Song>();
        }
    
        public int P_Id { get; set; }
        public string P_Name { get; set; }
        public int P_OwnerId { get; set; }
    
        public virtual User User { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
