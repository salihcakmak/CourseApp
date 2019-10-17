using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class Student
    {
        [Required(ErrorMessage="İsminizi giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage="Email adresinizi giriniz")]
        [EmailAddress(ErrorMessage="Doğru formatta mail adresi giriniz")]
        public string Mail { get; set; }
        [Required(ErrorMessage="Telefon bilgisini giriniz")]
        public string Phone { get; set; }
        [Required(ErrorMessage="Lütfen tercihinizi seçiniz")]
        public bool? Confirm { get; set; } //true ,false ,null olabilir.Validation kontrolünde sıkıntı çıkarmaması için.
    }
}