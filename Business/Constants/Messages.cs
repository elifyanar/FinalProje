using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime="Sistem bakımda.";
        public static string ProductListed="Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Ürün sayısı aşıldı";
        public static string ProductNameAlreadyExists = "Ürün ismi mevcut";
        public static string CategoryLimitExceded = "Kategori limiti açıldığı için yeni ürün eklenemiyor.";
    }
}
