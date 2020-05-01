using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp3.Models
{
    public class SampleFormModel
    {
        public string 不動産番号 { get; set; }
        public string 所在 { get; set; }
        public bool 物件種別_土地 { get; set; }
        public bool 物件種別_建物 { get; set; }
        public bool 物件種別_専有 { get; set; }
        public bool 所有権名義人単位で検索する { get; set; }
        public string 所有権名義人氏名 { get; set; }
    }
}
