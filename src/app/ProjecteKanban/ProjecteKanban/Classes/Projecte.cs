using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecteKanban.Classes
{
    internal class Projecte
    {
        // CAMPS PRIVATS
        private int _projecteId; 
        private int _idResponsable;
        private string _nomProjecte;
        private string _descripcio;
        private DateTime _dataCreacio; 
        private Nullable<DateTime> _dataFinalitzacio;

        // PROPIETATS
        public int ProjecteId 
        {
            get { return _projecteId; }
        }
        
        public int IdResponsable 
        {
            get { return _idResponsable; }
        }

        public string NomProjecte 
        {
            get { return _nomProjecte; }
        }

        public string Descripcio 
        {
            get { return _descripcio; }
        }

        public DateTime DataCreacio 
        {
            get { return _dataCreacio; }
        }

        public Nullable<DateTime> DataFinalitzacio 
        {
            get { return _dataFinalitzacio; }
        }

        // CONSTRUCTORS
        public Projecte (int idProjecte, int idResponsable, string nomProjecte, DateTime dataCreacio) 
        {
            AssignarProjecteId(idProjecte);
            AssignarIdResponsable(idResponsable);
            AssignarNomProjecte(nomProjecte);
            this._dataCreacio = dataCreacio;
        }

        // MÈTODES DE LA CLASSE
        private void AssignarProjecteId(int projecteId) // Els identificadors del projecte i del responsable han de ser positius
        {
            if (projecteId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(projecteId), "L'identificador de projecte ha de ser superior a '0'");
            }
            this._projecteId = projecteId;
        }

        private void AssignarIdResponsable(int idResponsable)
        {
            if (idResponsable <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(idResponsable), "L'identificador de responsable ha de ser superior a '0'");
            }
            this._idResponsable = idResponsable;
        }

        public void AssignarNomProjecte(string nomProjecte) // El nom és obligatori i es guarda sense espais als extrems amb 'Trim()'
        {
            if (string.IsNullOrWhiteSpace(nomProjecte))
            {
                throw new ArgumentException("El nom del projecte no pot quedar buit", nameof(nomProjecte));
            }
            this._nomProjecte = nomProjecte.Trim();
        }   
        
        public void AssignarDescripcio(string descripcio) // La descripció és opcional: un text buit o només amb espais eliminarà la descripció que hi havia
        {
            if (string.IsNullOrWhiteSpace(descripcio)) 
            {
                _descripcio = null;
            }
            else 
            {
                this._descripcio = descripcio.Trim();
            }
        }
    }
}