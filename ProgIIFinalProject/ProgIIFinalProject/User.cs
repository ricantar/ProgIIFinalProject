﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgIIFinalProject
{
    class User
    {
        private String _nombre;
        private String _apellido;
        private String _estado;
        private String _ID;
        private String _carrera;
        private String _identificadorPersonal;
        private DateTime _fechaNacimiento;
        private bool _extrangero;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value;}
        }
        public string apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string carrera
        {
            get { return _carrera; }
            set { _carrera = value; }
        }
        public string identificadorPersonal
        {
            get { return _identificadorPersonal; }
            set { _identificadorPersonal = value; }
        }
        public DateTime fechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        public bool extrangero
        {
            get { return _extrangero; }
            set { _extrangero = value; }
        }
    }
}
