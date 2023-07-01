

namespace WebShop.Models
{
    /// <summary>
    /// Загрузка фото на сервер
    /// </summary>
    public class ProdcutUploadImageViewModel
    {
        /// <summary>
        /// Передача фото у вигляді файлу
        /// </summary>
        public IFormFile Image { get; set; }
    }

    /// <summary>
    /// Вертамає інформацію про 1 фото товару
    /// </summary>
    public class ProdcutImageItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
