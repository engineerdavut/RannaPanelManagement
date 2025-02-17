﻿using RannaPanelManagement.Core.Entity;

namespace RannaPanelManagement.Entities
{
    public class Manager:IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email{ get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedDate{ get; set; }
    }
}
