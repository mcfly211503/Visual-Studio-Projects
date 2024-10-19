using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
    public class usuario
    {
        public string nombre { get; set; }
        public int id { get; set; }
        public int año { get; set; }
        public int mes { get; set; }
        public int dia { get; set; }
        public int edad { get; set; }
        public string informacion { get; set; }
        public List<libro> listaprestamos { get; set; }
        public int aab {get; set; }


        public usuario(string nombre, int id, int dia, int mes, int año)
        {
            this.nombre = nombre;
            this.id = id;
            this.dia = dia;
            this.mes = mes;
            this.año=año;
            this.edad = calcularedad(dia, mes, año);
            this.listaprestamos = new List<libro>();
            this.informacion = informacion;
        }

        public override string ToString()
        {
            return nombre + ", " + id;
        }

        public int calcularedad(int dia, int mes, int año)
        {
            if (mes <6) { return 2024 - año; }
            else if (mes ==6 && dia<=4) { return 2024 - año; }
            else { return (2024 - año-1); }
        }

      
        public void info()
        {
            string a = "Nombre: " + nombre
                     + "\nId: " + id.ToString()
                     + "\nEdad: " + edad.ToString()
                          + "\nLibros prestados: " + aab + "\n\n";
            informacion = a;
        }


        public void prestar(libro a)
        {
            aab++;
            a.prestado = "Actualmente, prestado a " + nombre;
            listaprestamos.Add(a);
            
            a.info();
            info();
            MessageBox.Show("Se ha prestado el libro:\n" + a.informacion, "Felicidades", MessageBoxButtons.OK);
        }

        public void devolver(libro a)
        {
            aab--;
            a.prestado = "Actualmente, disponible para prestamo";
           
            a.info();
            info();
            MessageBox.Show("Se ha Devuelto el libro:\n" + a.informacion, "Felicidades", MessageBoxButtons.OK);
        }
    }
}
