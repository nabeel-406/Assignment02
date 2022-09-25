﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_Management_System.Models
{
    public class Room
    {
        
        public Guid RoomId { get; set; }
        public bool room_status { get; set; }
        public string room_comment { get; set; }    
        public string room_inventory { get; set; }  
        public float room_price { get; set; }
    }
}
