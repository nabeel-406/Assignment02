﻿namespace Hotel_Management_System.Models
{
    public class Guest
    {
        public Guid GuestId { get; set; }
        public string GuestName { get; set; }
        
        public string GuestEmail { get; set; }
        public int GuestAge { get; set; }
        public long GuestPhoneNumber { get; set; }
        public long GuestAdhaarCard { get; set; }
        public string GuestAddress { get; set; }
    }
}
