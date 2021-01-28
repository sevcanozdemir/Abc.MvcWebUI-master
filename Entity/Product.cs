using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Ürün Açıklaması")]
        public string Description { get; set; }
        [Required]
        [DisplayName("Fiyat")]
        public double Price { get; set; }
        [Required]
        [DisplayName("Stok")]
        public int Stock { get; set; }
        [Required]
        [DisplayName("Resim")]
        public string Image { get; set; }
        [Required]
        [DisplayName("Onaylı mı?")]
        public bool IsApproved { get; set; }
        [Required]
        [DisplayName("Mevcut mu?")]
        public bool IsHome { get; set; }
        [Required]
        [DisplayName("Kategori")]
        public int CategoryId { get; set; }
        [Required]
        [DisplayName("Kategori")]
        public Category Category { get; set; }
    }
}