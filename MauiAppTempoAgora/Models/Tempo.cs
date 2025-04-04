using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTempoAgora.Models
{
    public class Tempo //de internal pra public pra poder chamar dps chamar em outro arquivos
    {
        //variáveis da classe que contêm dados sobre o tempo e que podem ser manipuladas ou
        //lidas
        public double? lon { get; set; }
        public double? lat { get; set; }
        public double? temp_min { get; set; }
        public double? temp_max { get; set; }
        public int? visibility { get; set; }
        public string? sunrise { get; set; }
        public string? sunset { get; set; }
        public string? description { get; set; }
        public string? main { get; set; }
        public double? speed { get; set; }
        public int? deg { get; set; }

        //contem o que o código precisa para exibir a previsão do tempo, é uma classe C#
        //
    }

    
    
}

