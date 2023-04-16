using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public enum Nivel
    {
        Básico,
        Intermedio,
        Avanzado
    }
    public class Curso  :   BaseEntity
    {
        [Required]
        public String NameCurso { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public String DescriptionShort { get; set; } = string.Empty;
        public string DescriptionLong { get; set; } = string.Empty;
        public string publicObject { get; set; } = string.Empty;
        public string objectives { get; set; } = string.Empty;
        public string requirements { get; set; } = string.Empty;
        public Nivel level { get; set; } 
    }
}
