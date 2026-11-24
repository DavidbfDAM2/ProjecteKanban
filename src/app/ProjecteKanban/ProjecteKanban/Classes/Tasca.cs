using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecteKanban.Classes
{
    internal class Tasca
    {
        int tascaId;
        int idColumn;
        int idUser;
        string nomTasca; 
        string descripcio;
        DateTime dataCreacio;
        DateTime dataPrevistaFinalitzacio;
        DateTime dataRealFinalitzaci;
        DateTime dataMod;
        
        enum prioritat 
        {
            Baixa, 
            Mitjana, 
            Alta 
        };

    }
}
