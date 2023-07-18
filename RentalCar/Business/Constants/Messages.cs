using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorListed = "Renk listelendi";
        public static string ColorNameInvalid = "Renk ismi 2 karakterden fazla olmaldır";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandListed = "Marka listelendi";
        public static string BrandNameInvalid = "Marka ismi 2 karakterden fazla olmalıdır";
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarListed = "Araba listelendi";
        public static string CouldNotAddCar = "Araba eklenemedi. Araba ismi geçersiz yada araba günlük fiyatı geçersiz";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullancı güncellendi";
        public static string UserListed = "Kullanıcılar listelendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri silindi";
        public static string CustomerListed = "Müşteriler listelendi";
        public static string RentalAdded = "Araba kiralandı";
        public static string CarNotDelivered = "Araba teslim edilmemiş";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalUpdated = "Kiralama güncellendi";
        public static string RentalListed = "Kiralama Listelendi";
        public static string ImageAdded = "Resim eklendi";
        public static string ImageDeleted = "Resim silindi";
        public static string CarImageUpdated = "Resim güncellendi";
        public static string CarImageListed = "Resimler listelendi";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı kayıtlı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string RentalDtoListed = "Kiralamalar Listelendi";
    }
}
