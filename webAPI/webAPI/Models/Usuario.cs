using System;

namespace webAPI.Models
{
    public class Usuario
    {
        public Int32 ID { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Chapa { get; set; }
        public string celular { get; set; }
        public string DtNasc { get; set; }
        public string Ramal { get; set; }
        public string Email { get; set; }
        public string Area { get; set; }
        public Int32 IdArea { get; set; }
        public string Foto { get; set; }
        public string base64 { get; set; }
    }
}