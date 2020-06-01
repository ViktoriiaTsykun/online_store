using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Введіть своє ім'я:")]
        [StringLength(25, ErrorMessage = "Довжина імені має бути принаймні 2 символи!", MinimumLength = 2)]
        [Required(ErrorMessage = "Ім'я обов'язкове для заповнення!")]
        public string name { get; set; }

        [Display(Name = "Введіть своє прізвище:")]
        [StringLength(25, ErrorMessage = "Довжина прізвища має бути принаймні 3 символи!", MinimumLength = 3)]
        [Required(ErrorMessage = "Прізвище обов'язкове для заповнення!")]
        public string surname { get; set; }

        [Display(Name = "Введіть свою адресу:")]
        [StringLength(100, ErrorMessage = "Довжина імені має бути принаймні 10 символів!", MinimumLength = 10)]
        [Required(ErrorMessage = "Адреса обов'язкова для заповнення!")]
        public string address { get; set; }

        [Display(Name = "Введіть свій телефон:")]
        [StringLength(15, ErrorMessage = "Довжина номеру має бути принаймні 10 символів!", MinimumLength = 10)]
        [Required(ErrorMessage = "Телефон обов'язковий для заповнення!")]
        [DataType(DataType.PhoneNumber)]
        public string phone { get; set; }

        [Display(Name = "Введіть свою пошту:")]
        [StringLength(40, ErrorMessage = "Довжина пошти має бути принаймні 11 символів!", MinimumLength = 11)]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
