using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolaWeb.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HolaWeb.App.Dominio;

namespace HolaWeb.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        // private string [] saludos = {"Buenos días", "Buenas tardes", "Buenas noches", "Hasta mañana"};
        
        // public List<string> ListaSaludos {get;set;}

        private readonly IRepositoriosSaludos repositoriossaludos;
        public IEnumerable<Saludo> Saludos {get;set;}

        public ListModel(IRepositoriosSaludos repositoriossaludos)
        {
            this.repositoriossaludos=repositoriossaludos;
        }

        public void OnGet()
        {
            // ListaSaludos = new List<string>();
            // ListaSaludos.AddRange(saludos);
            Saludos = repositoriossaludos.GetAll();
        }
    }
}
