using LIstaDeTarefaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LIstaDeTarefaAPI.Data
{
    public class ListaTarefasAPI : DbContext
    {
        public ListaTarefasAPI(DbContextOptions<ListaTarefasAPI> options) : base(options)
        {
        }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<TipoTarefa> TipoTarefas { get; set; }
    }
}
