using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    //Bu projeye ait sabit şeyler bu klasör içinde olacak
    public static class Messages
    {
        public static string WorkAdded = "İş Eklendi.";
        public static string WorkerAdded = "İşçi Eklendi.";
        public static string PlanAdded = "Plan Eklendi.";
        public static string WorkNameInvalid = "Ürün ismi Geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string WorksListed=  "İşler Listelendi.";
        public static string WorkersListed = "İşçiler Listelendi.";
        public static string PlansListed = "Planlar Listelendi.";
        public static string WorkDeleted = "İş Silindi.";
        public static string WorkerDeleted = "İşçi Silindi.";
        public static string PlanDeleted = "Plan Silindi.";
        public static string WorkUpdated = "İş güncellendi.";
        public static string WorkerUpdated = "İşçi güncellendi.";
        public static string PlanUpdated = "Plan güncellendi.";
        public static string PlanDetailListed = "Planların detayları listelendi.";
        public static string WorkNameAlreadyExists="Bu isimde başka bir ürün zaten var";
        public static string AuthorizationDenied="Yetkiniz yok!!!";
        public static string UserRegistered="Kayıt Başarılı.";
        public static string UserNotFound="Böyle bir kullanıcı bulunamadı.";
        public static string PasswordError="Şifre hatalı";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string UserAlreadyExists="Kullanıcı mevcut";
        public static string AccessTokenCreated="Token oluşturuldu.";
    }
}
