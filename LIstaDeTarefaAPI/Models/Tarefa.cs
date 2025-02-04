namespace LIstaDeTarefaAPI.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public bool Concluida { get; set; }
        public int TipoTarefaId { get; set; }
        public TipoTarefa? TipoTarefa { get; set; }
    }
}
