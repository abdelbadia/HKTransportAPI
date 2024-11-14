using HKTransportAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HKTransportAPI.Models
{
    public class Client
    {
        [Key]
        public int client_id { get; set; }

        public string nom { get; set; }
        public string numero_TVA { get; set; }
        public string adresse { get; set; }
        public string code_postal { get; set; }
        public string ville { get; set; }
        public string pays { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
        public string statut { get; set; }

    }
}
