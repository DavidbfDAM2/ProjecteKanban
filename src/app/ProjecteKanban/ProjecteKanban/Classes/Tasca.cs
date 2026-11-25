using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecteKanban.Classes
{
    enum PrioritatTasca
    {
        Baixa,
        Mitjana,
        Alta
    };

    internal class Tasca
    {
        // CAMPS PRIVATS 

        private int _tascaId;
        private int _idColumna;
        private int _idUsuari;
        private string _nomTasca; 
        private string _descripcio;
        private DateTime _dataCreacio;
        private DateTime _dataPrevistaFinalitzacio;
        private PrioritatTasca _prioritat;
        
        // PROPIETATS
        
        public int TascaId 
        {
            get { return _tascaId; }
        }

        public int IdColumn 
        {
            get { return _idColumna; }
        }

        public int IdUsuari 
        {
            get { return _idUsuari; }
        }

        public string NomTasca 
        {
            get { return _nomTasca; }
        }

        public string Descripcio
        {
            get { return _descripcio; }
        }

        public DateTime DataCreacio
        {
            get { return _dataCreacio; }
        }

        public DateTime DataPrevistaFinalitzacio
        {
            get { return _dataPrevistaFinalitzacio; }
        }
        
        public PrioritatTasca Prioritat 
        {
            get { return _prioritat; }
        }   

        // CONSTRUCTORS
        public Tasca (int tascaId, string descripcio, DateTime dataCreacio, DateTime novaDataFinalitzacio, string nomTasca, int idColumna, int idResponsable) 
        {
            if (tascaId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(tascaId), "L’identificador de la tasca ha de ser superior a zero.");
            }
            this._tascaId = tascaId;
            AssignarDescripcio(descripcio);
            this._prioritat = PrioritatTasca.Mitjana;
            this._dataCreacio = dataCreacio;                            // Cal guardar la data de creació abans de validar la data prevista
            AssignarDataPrevistaFinalitzacio(novaDataFinalitzacio);
            AssignarNomTasca(nomTasca);
            AssignarColumna(idColumna);
            AssignarResponsableTasca(idResponsable);
        }

        // MÈTODES DE LA CLASSE        
        public void AssignarDescripcio(string novaDescripcio)   // La descripció és obligatòria. Rebutgem el text null, buit o que contingui només espais
        {
            if (string.IsNullOrWhiteSpace(novaDescripcio)) 
            {
                throw new ArgumentException("La descripció no pot queda buida", nameof(novaDescripcio));
            }
            this._descripcio = novaDescripcio; 
        }
        
        public void AssignarPrioritatTasca(PrioritatTasca novaPrioritat)    // Rebutgem valors que no corresponen a cap prioritat definida
        {
            if(!Enum.IsDefined(typeof(PrioritatTasca), novaPrioritat)) 
            {
                throw new ArgumentOutOfRangeException(nameof(novaPrioritat), "La prioritat no és vàlida");
            }
            this._prioritat = novaPrioritat;
        }
        
        public void AssignarDataPrevistaFinalitzacio(DateTime novaDataPrevista) // Comparem només les dates: la previsió pot ser el mateix dia de creació, però no abans
        {
            if(novaDataPrevista.Date < _dataCreacio.Date) 
            {
                throw new ArgumentOutOfRangeException(nameof(novaDataPrevista), "La data prevista no pot ser anterior a la data de creació");
            }
            this._dataPrevistaFinalitzacio = novaDataPrevista.Date;
        }

        public void AssignarNomTasca(string nouNomTasca) 
        {
            if (string.IsNullOrWhiteSpace(nouNomTasca)) 
            {
                throw new ArgumentException("El nom de la tasca no pot quedar buit", nameof(nouNomTasca));
            }
            this._nomTasca = nouNomTasca.Trim();
        }
        
        public void AssignarColumna(int idColumna) // Comprovem que l'ID sigui positiu, no que la columna existeixi (L'API comprovarà que la columna existeix i pertany al projecte)
        {
            if (idColumna <= 0) 
            {
                throw new ArgumentOutOfRangeException(nameof(idColumna), "L'identificador de la columna ha de ser superior a '0'");
            }
            this._idColumna = idColumna;
        }

        public void AssignarResponsableTasca(int idResponsable) 
        {
            if(idResponsable <= 0) 
            {
                throw new ArgumentOutOfRangeException(nameof(idResponsable), "L'identificador d'usuari ha de ser superior a '0'");
            }
            this._idUsuari = idResponsable;
        }
    }    
}