using E_TradeAppUI.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace E_TradeAppUI.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        [DisplayName("İsim")]
        [StringLength(maximumLength: 30, ErrorMessage = "dsakldşa")]
        public string Name { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }
        [DisplayName("Fiyat")]
        public int Price { get; set; }
        public int Stock { get; set; }
        public string Picture { get; set; }
        public bool IsHome { get; set; }
        public bool IsApproved { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}