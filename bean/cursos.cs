using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEstudiantes.bean
{
    class cursos
    {
        private int idEstudiante;
        private int Matematicas;
        private int Comunicacion;
        private int Religion;
        private int Historia;
        private int Ciencias;
        private int Civica;
        private int Psicologia;
        private int Total;
        private string Observaciones;
        public cursos()
        {
            this.idEstudiante = 0;
            this.Matematicas = 0;
            this.Comunicacion = 0;
            this.Religion = 0;
            this.Historia = 0;
            this.Ciencias = 0;
            this.Civica = 0;
            this.Psicologia = 0;
            this.Total = 0;
            this.Observaciones = "";
        }

        public int IdEstudiante { get => idEstudiante; set => idEstudiante = value; }
        public int Matematicas1 { get => Matematicas; set => Matematicas = value; }
        public int Comunicacion1 { get => Comunicacion; set => Comunicacion = value; }
        public int Religion1 { get => Religion; set => Religion = value; }
        public int Historia1 { get => Historia; set => Historia = value; }
        public int Ciencias1 { get => Ciencias; set => Ciencias = value; }
        public int Civica1 { get => Civica; set => Civica = value; }
        public int Psicologia1 { get => Psicologia; set => Psicologia = value; }
        public int Total1 { get => Total; set => Total = value; }
        public string Observaciones1 { get => Observaciones; set => Observaciones = value; }
    }
}
