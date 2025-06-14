using ToDoAula.Models.Enums;

namespace ToDoAula.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDeCriacao { get; set; }
        public DateTime? DataDeConclusao { get; set; }
        public Categoria Categoria { get; set; }
        public Status Status { get; set; }
    }
}
