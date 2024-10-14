using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Qr_and_Bar_code_Generator.Models
{
    public class QrModel
    {
        [Display]
        [Required]
        public string QRCodeText { get; set; }
        [Display]
        [Required]
        public string BarCodeText { get; set; }
    }
}