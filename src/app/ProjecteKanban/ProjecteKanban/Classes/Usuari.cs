using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecteKanban.Classes
{
    internal class Usuari
    {
        // CAMPS PRIVATS
        private int _usuariId;
        private string _nomUsuari;

        // PROPIETATS
        public int UsuariId 
        {
            get { return _usuariId; }
        }

        public string NomUsuari 
        {
            get { return _nomUsuari; }
        }
               

        // CONSTRUCTORS

        public Usuari (int usuariId, string nomUsuari) 
        {
            AssignarUsuariId(usuariId);
            AssignarNomUsuari(nomUsuari);

        }
        // MÈTODES DE LA CLASSE
        
        private void AssignarUsuariId(int usuariId) // Validem i guardem un ID positiu en crear l'usuari
        {
            if (usuariId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(usuariId), "L'identificador d'usuari ha de ser superior a '0'");
            }
            this._usuariId = usuariId;
        }
        
        public void AssignarNomUsuari(string nomUsuari) // El nom no pot quedar buit i es guarda sense espais als extrems amb 'Trim()'
        {
            if (string.IsNullOrWhiteSpace(nomUsuari))
            {
                throw new ArgumentException("El nom de l'usuari no pot quedar buit", nameof(nomUsuari));
            }
            this._nomUsuari = nomUsuari.Trim();
        }        
    }
}