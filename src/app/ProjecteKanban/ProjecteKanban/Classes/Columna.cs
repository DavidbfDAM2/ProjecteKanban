using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecteKanban.Classes
{
    internal class Columna
    {
        // CAMPS PRIVATS
        private int _columnaId; 
        private int _idProjecte;
        private string _nomColumna;

        // PROPIETATS 
        public int ColumnaId 
        {
            get { return _columnaId; }
        }

        public int IdProjecte 
        {
            get { return _idProjecte; }
        }

        public string NomColumna
        {
            get { return _nomColumna; }
        }

        // CONSTRUCTORS
        public Columna (int columnaId, int idProjecte, string nomColumna) 
        {
            AssignarIdColumna(columnaId);
            AssignarIdProjecte(idProjecte);
            AssignarNomColumna(nomColumna);
        }

        // MÈTODES DE LA CLASSE
        private void AssignarIdColumna(int columnaId)   // Els identificadors de columna i de projecte han de ser positius i només s'assignen en crear la columna
        {
            if(columnaId <= 0) 
            {
                throw new ArgumentOutOfRangeException(nameof(columnaId), "L'identificador de columna ha de ser superior a '0'");
            }
            this._columnaId = columnaId;
        }

        private void AssignarIdProjecte(int idProjecte)
        {
            if (idProjecte <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(idProjecte), "L'identificador de projecte ha de ser superior a '0'");
            }
            this._idProjecte = idProjecte;
        }
        
        public void AssignarNomColumna(string nomColumna)   // Permet canviar el nom de la columna sense canviar el seu ID; el nom no pot quedar buit
        {
            if (string.IsNullOrWhiteSpace(nomColumna))
            {
                throw new ArgumentException("El nom de la columna no pot quedar buit", nameof(nomColumna));
            }
            this._nomColumna = nomColumna;
        }
    }
}