using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_TradeAppUI.Models
{
    public class Login
    {
        [Required]
        [DisplayName("Kullanıcı adı")]
        public string Username { get; set; }

        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }

        [Required]
        [DisplayName("Beni Hatırla")]
        public bool Rememberme { get; set; }

    }


}