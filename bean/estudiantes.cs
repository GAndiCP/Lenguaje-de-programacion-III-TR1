using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEstudiantes.bean
{
    class estudiantes
    {
        private int id;
        private string Pnombre;
        private string Snombre;
        private string Papellido;
        private string Sapellido;
        private string Telefono;
        private string Celular;
        private string Direccion;
        private string Email;
        private string Fnacimiento;

        public estudiantes()
        {
            this.id = 0;
            this.Pnombre = "";
            this.Snombre = "";
            this.Papellido = "";
            this.Sapellido = "";
            this.Telefono = "";
            this.Celular = "";
            this.Direccion = "";
            this.Email = "";
            this.Fnacimiento = "";
        }

        public int Id { get => id; set => id = value; }
        public string Pnombre1 { get => Pnombre; set => Pnombre = value; }
        public string Snombre1 { get => Snombre; set => Snombre = value; }
        public string Papellido1 { get => Papellido; set => Papellido = value; }
        public string Sapellido1 { get => Sapellido; set => Sapellido = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public string Celular1 { get => Celular; set => Celular = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Fnacimiento1 { get => Fnacimiento; set => Fnacimiento = value; }
    }
}
