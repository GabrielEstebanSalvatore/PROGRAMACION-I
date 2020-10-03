using PROGRAMACION_I.Player;
using System.Collections.Generic;

namespace PROGRAMACION_I.Data
{
    public class SinglePlayer
    {
        public SinglePlayer()
        {

        }
        public SinglePlayer(string Name)
        {
            this.Name = Name;
        }
        public int ID { get; set; }

        public string Name { get; set; }

        public IEnumerable<DarVueltaScore> DarVueltasScores { get; set; }
        public IEnumerable<AdivinaCartaScore> AdivinaLaCartaScores { get; set; }
        public IEnumerable<QuinielaScore> QuinielaScores { get; set; }

    }
}
