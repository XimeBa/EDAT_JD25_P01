using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UI.NumerosAleatorios
{
    public class Empleado
    {
        private int _intNumero;
        private string _strNombre, _strSexo;
        private DateTime _dtmFechaNacimiento;
        private char _chrGrupo;
        private double _dblSueldo;
        private bool _blnSeguroMedico;

        public int Numero
        {
            get { return _intNumero; }
            set { _intNumero = value; }
        }

        public string Nombre 
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        public DateTime FechaNacimiento 
        {
            get { return _dtmFechaNacimiento; }
            set { _dtmFechaNacimiento = value; }
        }

        public string Sexo
        {
            get { return _strSexo; }
            set { _strSexo = value; }
        }

        public char Grupo
        {
            get { return _chrGrupo; }
            set { _chrGrupo = value; }
        }

        public double Sueldo
        {
            get { return _dblSueldo; }
            set { _dblSueldo = value; }
        }

        public bool SeguroMedico
        {
            get { return _blnSeguroMedico; }
            set { _blnSeguroMedico = value; }
        }

        public override string ToString()
        {
            return  "Número: " + Numero + "\n" +                  // "/n" es para dar espacidos dentro de cada opción
            "Nombre: " + Nombre + "\n" +
            "Fecha de Nacimiento: " + FechaNacimiento + "\n" +
            "Sexo: " + Sexo+ "\n" +
            "Grupo: " + Grupo + "\n" +
            "Sueldo:  " + Sueldo + "\n" +
            "Seguro Médico: " + SeguroMedico ;
        }
    }   
}
