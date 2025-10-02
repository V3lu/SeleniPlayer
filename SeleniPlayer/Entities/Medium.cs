using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniPlayer.Entities
{
    public class Medium
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public float Length { get; set; }
        public int Size { get; set; }
        public List<Playlist> Playlists { get; set; } = [];
        public int OwnerId { get; set; }
        public User Owner { get; set; }
    }
}
