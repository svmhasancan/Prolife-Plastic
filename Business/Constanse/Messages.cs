using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constanse
{
    public static class Messages
    {
        // Brand
        
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdated = "Marka Güncellendi";

        // Category
        public static string CategoryAdded = "Kategori Eklendi";
        public static string CategoryDeleted = "Kategori Silindi";
        public static string CategoryUpdated = "Kategori Güncellendi";

        // Product
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductDeleted = "Ürün Silindi";
        public static string ProductUpdated = "Ürün Güncellendi";

        // Product Image
        public static string ProductImageAdded = "Ürün Resmi Eklendi";
        public static string ProductImageUpdated = "Ürün Resmi Güncellendi";
        public static string ProductImageDeleted = "Ürün Resmi Silindi";

        // User
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string EmailAlreadyExists = "Bu E-Mail Sistemde Kayıtlı";
        public static string UserAlreadyExists = "Kullanıcı Sistemde Kayıtlı";
        public static string PasswordError = "Hatalı Şifre";
        public static string SuccessfulyLogin = "Giriş Başarılı";
        public static string AccessTokenCreated = "Access Token Oluşturuldu";
    }
}
