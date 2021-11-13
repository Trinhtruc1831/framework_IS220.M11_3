using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IS220.M11.Models
{
    public class banModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BanID {get; set;}

        [Display(Name ="Ngày khóa")]
        public DateTime BDate{get; set;}
        [Display(Name ="Nguyên nhân khóa")]
        public string BReason {get; set;}
        [Display(Name ="Ngày mở khóa")]
        public DateTime FreeDate {get; set;}

        [ForeignKey("accountModel")]
        [Display(Name ="Mã tài khoản bị khóa")]
        public int BedUserID {get; set;}

        [ForeignKey("accountModel")]
        [Display(Name ="Mã tài khoản khóa")]
        public int BUserID {get; set;}
        public accountModel accounts {get; set;}

    }
}