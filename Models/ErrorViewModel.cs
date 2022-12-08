using System;

namespace lab4_idweb.Models
{
     public class ErrorViewModel
     {
          public string RequestId { get; set; }

          public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
     }
}
