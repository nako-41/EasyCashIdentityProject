﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.AppUserDto
{
    public class AppUserRegisterDto
    {
        //[Required(ErrorMessage ="name is required")]
        //[Display(Name="Isim :")]
        //[MaxLength(30)]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }
}

//ad,soyad,username,mail,password,confirmapassword
