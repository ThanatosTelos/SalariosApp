using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalariosApp
{
    public static class Global
    {
        public static List<Empleado> Empleados = new List<Empleado>()
        {
            new Empleado(1,1968,"Burgos","Jeronimo","Palmira","Administración","Administrativo",3200000,"5-Apr","28-Sept")
            ,new Empleado(2,1674,"Villegas","Estefania","Palmira","Administración","Docente",3200000,"25-Mar","17-Jan")
            ,new Empleado(3,1056,"Santana","Javier","Monteria","Comunicación","Administrativo",5600000,"25-Oct","24-Aug")
            ,new Empleado(4,1977,"Saldarriaga","Virginia","Monteria","Comunicación","Docente",4200000,"9-Sep","9-Sep")
            ,new Empleado(4,1931,"Arango","Felipe","Medellín","Administración","Administrativo",2560000,"20-Jun","28-May")
            ,new Empleado(4,1967,"Betancurt","Santiago","Bucaramanga","Administración","Aux.Administrativo",1350000,"9-Nov","15-May")
            ,new Empleado(4,1054,"Suarez","Miguel","Bogotá","Derecho","Docente investigador",4100000,"16-Apr","9-Aug")
        };
    }

    public class Empleado
    {
        int id;
        int idempleado;
        string apellido;
        string nombre;
        string seccional;
        string facultad;
        string cargo;
        double salario;
        string inicio;
        string nacimiento;

        public Empleado(int id, int idempleado, string apellido, string nombre, string seccional, string facultad, string cargo, double salario, string inicio, string nacimiento)
        {
            this.id = id;
            this.idempleado = idempleado;
            this.apellido = apellido;
            this.nombre = nombre;
            this.seccional = seccional;
            this.facultad = facultad;
            this.cargo = cargo;
            this.salario = salario;
            this.inicio = inicio;
            this.nacimiento = nacimiento;
        }

        public int Id { get => id; set => id = value; }
        public int Idempleado { get => idempleado; set => idempleado = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Seccional { get => seccional; set => seccional = value; }
        public string Facultad { get => facultad; set => facultad = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Inicio { get => inicio; set => inicio = value; }
        public string Nacimiento { get => nacimiento; set => nacimiento = value; }
    }
}