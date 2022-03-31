using BlazorPeliculas.Shared.Entidades;
using System;
using System.Collections.Generic;

namespace BlazorPeliculas.Client.Repositorios
{
    public class Repositorio:IRepositorio 
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>()

        {
            new Pelicula(){Titulo = "Spider-Man",Lanzamiento = new DateTime(2019, 12, 23),Poster="img/spider.jpg"},
            new Pelicula(){Titulo = "Moana",Lanzamiento = new DateTime(2019, 12, 23),Poster="img/moana.jpg"},
            new Pelicula(){Titulo = "Inception",Lanzamiento = new DateTime(2019, 12, 23),Poster="img/inception.jpg"},
        };
        }
    }
}
