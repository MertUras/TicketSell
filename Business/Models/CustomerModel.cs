﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
	public class CustomerModel
	{
		

         public int Id { get; set; }

       
        public string UserName { get; set; }

       
        public string Email { get; set; }

        
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; }
  
	}
}

