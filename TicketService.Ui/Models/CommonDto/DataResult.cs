using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketService.Ui.Models.CommonDto
{
    public class DataResult<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
    }
}