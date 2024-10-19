using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{

    public class libro
    {
        public string titulo { get; set; }
        public string autor { get; set; }
        public int code { get; set; }
        public string restriccion { get; set; }

        public string informacion { get; set; }

        public string prestado {  get; set; }

        public libro(string titulo, string autor, int code)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.code = code;
            this.restriccion = res(code);
            this.informacion = informacion;
            this.prestado = "Actualmente, disponible para prestamo";

        }
        public string res (int a)
        {
            if (a == 0) { return "Apto para todo Público"; }
            else if (a == 1) { return "Solo apto para mayores de edad"; }
            return "No se tiene informacion al respecto";
        }

        public override string ToString()
        {
            string a = "Libro: " + titulo
                     + ", Autor: " + autor;
            return a;
        }

        public void info()
        {
             string a = "Libro: " + titulo
                     + "\nAutor: " + autor
                     + "\nContenido para: " + restriccion
                          + "\nDisponibilidad: " + prestado+"\n\n";
            informacion =a;
        }
    }
}
