using System.Collections.Generic;
using HolaWeb.App.Dominio;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public class RepositoriosSaludosMemoria : IRepositoriosSaludos
    {

        List<Saludo> saludos;

        public RepositoriosSaludosMemoria()
        {
            saludos = new List<Saludo>()
            {
                new Saludo{Id=1, EnEspanol="Buenos días", EnIngles="Good morning", EnItaliano="Buon giorno"},
                new Saludo{Id=2, EnEspanol="Buenas tardes", EnIngles="Good afternoon", EnItaliano="Buon Pomeriggio"},
                new Saludo{Id=13, EnEspanol="Buenas noches", EnIngles="Good evening", EnItaliano="Buon sera"}

            };

        }

        public IEnumerable<Saludo> GetAll()
        {
            return saludos;
        }
    }
}