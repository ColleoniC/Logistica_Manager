using System.Drawing;

namespace Progetto_GPO
{
    internal static class Tema
    {
        public static readonly Color Primario = Color.FromArgb(2, 62, 138);
        public static readonly Color PrimarioHover = Color.FromArgb(3, 4, 94);
        public static readonly Color Intestazione = Color.FromArgb(30, 64, 175);
        public static readonly Color IntestazioneSpeciale = Color.FromArgb(2, 62, 138);
        public static readonly Color Accento = Color.FromArgb(32, 191, 85);

        public static readonly Color SfondoForm = Color.FromArgb(245, 245, 245);
        public static readonly Color SfondoGruppo = Color.White;
        public static readonly Color SfondoGriglia = Color.FromArgb(248, 250, 252);

        public static readonly Color TestoEtichetta = Color.FromArgb(55, 55, 65);
        public static readonly Color TestoSecondario = Color.FromArgb(100, 100, 110);
        public static readonly Color TestoCella = Color.FromArgb(35, 42, 52);
        public static readonly Color TestoChiaro = Color.White;

        public static readonly Color CellaCosto = Color.White;
        public static readonly Color CellaProduzione = Color.FromArgb(219, 234, 254);
        public static readonly Color CellaFabbisogno = Color.FromArgb(220, 252, 231);
        public static readonly Color CellaTotale = Color.FromArgb(32, 191, 85);
        public static readonly Color CellaTotaleSbilanciata = Color.FromArgb(220, 38, 38);
        public static readonly Color CellaAllocata = Color.FromArgb(255, 237, 213);
        public static readonly Color TestoAllocata = Color.FromArgb(154, 52, 18);
        public static readonly Color Selezione = Color.FromArgb(171, 196, 255);

        public static readonly Color Evidenziazione = Color.FromArgb(254, 240, 138);
        public static readonly Color EvidenziazioneCella = Color.FromArgb(250, 204, 21);

        private const string Famiglia = "Segoe UI";

        public static readonly Font FontTitolo = new Font(Famiglia, 14.25F, FontStyle.Bold);
        public static readonly Font FontGruppo = new Font(Famiglia, 10F, FontStyle.Bold);
        public static readonly Font FontEtichetta = new Font(Famiglia, 9.75F, FontStyle.Regular);
        public static readonly Font FontSuggerimento = new Font(Famiglia, 9F, FontStyle.Italic);
        public static readonly Font FontBottone = new Font(Famiglia, 10.5F, FontStyle.Bold);
        public static readonly Font FontBottonePrincipale = new Font(Famiglia, 14.25F, FontStyle.Bold);
        public static readonly Font FontCella = new Font(Famiglia, 11.25F, FontStyle.Regular);
        public static readonly Font FontCellaGrassetto = new Font(Famiglia, 11.25F, FontStyle.Bold);
        public static readonly Font FontIntestazione = new Font(Famiglia, 10F, FontStyle.Bold);
        public static readonly Font FontCostoTotale = new Font(Famiglia, 13F, FontStyle.Bold);
    }
}