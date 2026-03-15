namespace Polaris.Data
{
    public enum TiposProyectos
    {
        PolariX,
        Mentes_en_Órbita,
        Hydronautas
    }
    public class NameTiposProyectos
    {
        public TiposProyectos tiposProyectos {  get; set; }
        public string ToString()
        {
            return tiposProyectos.ToString().Replace("_", " ");
        }

    }
}
