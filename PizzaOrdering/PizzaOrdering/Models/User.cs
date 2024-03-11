using System.ComponentModel.DataAnnotations;

public class User
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Поле 'Имя' обязательно для заполнения.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Поле 'Возраст' обязательно для заполнения.")]
    [Range(0, int.MaxValue, ErrorMessage = "Возраст должен быть больше 0.")]
    public int Age { get; set; }
}
