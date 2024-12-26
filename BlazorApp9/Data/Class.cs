using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp9.Data
{
    // Класс для представления мест
    public class Place
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; } = string.Empty; // Установлен пустой строкой по умолчанию

        public string Description { get; set; } = string.Empty; // Установлен пустой строкой по умолчанию
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }


    // Класс для представления гидов
    public class Guide
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        [StringLength(100, ErrorMessage = "The Name cannot exceed 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Invalid Phone Number.")]
        public string Phone { get; set; }
    }

    // Класс для представления туров
    public class Tour
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        // Связь с гидом
        [ForeignKey("Guide")]
        public int? GuideId { get; set; }
        public Guide? Guide { get; set; }

        // Координаты начала маршрута
        [Required]
        public double StartLatitude { get; set; }

        [Required]
        public double StartLongitude { get; set; }

        // Координаты конца маршрута
        [Required]
        public double EndLatitude { get; set; }

        [Required]
        public double EndLongitude { get; set; }
    }

    // Класс для представления отзывов
    public class Review
    {
        public int Id { get; set; } // Уникальный идентификатор отзыва
        public int TourId { get; set; } // Идентификатор тура
        public string UserName { get; set; } // Имя пользователя, оставившего отзыв
        public string Content { get; set; } // Содержание отзыва
        public DateTime Date { get; set; } // Дата отзыва
    }
}
