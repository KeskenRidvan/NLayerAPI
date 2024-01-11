namespace Business.Constants;

public static class Messages
{
	#region Product
	public static string ProductAdded = "Ürün başarıyla eklendi!";
	public static string ProductUpdated = "Ürün başarıyla eklendi!";
	public static string ProductDeleted = "Ürün başarıyla silindi!";
	public static string ProductsListed = "Ürünler listelendi!";
	public static string ProductListed = "Ürün listelendi!";
	public static string ProductsListedByCategory = "Ürünler kategoriye göre listelendi!"; 
	public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir"; 
	public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
	#endregion

	#region Customer
	public static string CustomerAdded = "Müşteri başarıyla eklendi!";
	public static string CustomerUpdated = "Müşteri başarıyla eklendi!";
	public static string CustomerDeleted = "Müşteri başarıyla silindi!";
	public static string CustomersListed = "Müşteriler listelendi!";
	public static string CustomerListed = "Müşteri listelendi!";
	#endregion

	#region Order
	public static string OrderAdded = "Sipariş başarıyla eklendi!";
	public static string OrderUpdated = "Sipariş başarıyla eklendi!";
	public static string OrderDeleted = "Sipariş başarıyla silindi!";
	public static string OrdersListed = "Siparişler listelendi!";
	public static string OrderListed = "Sipariş listelendi!";
	#endregion

	#region Category
	public static string CategoryAdded = "Kategori başarıyla eklendi!";
	public static string CategoryUpdated = "Kategori başarıyla eklendi!";
	public static string CategoryDeleted = "Kategori başarıyla silindi!";
	public static string CategoriesListed = "Kategoriler listelendi!";
	public static string CategoryListed = "Kategori listelendi!"; 
	public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
	#endregion


	#region User
	public static string UserOrPasswordError = "Kullanıcı Şifresi Veya Emaili Hatalı!";
	public static string SuccessfullLogin = "Kullanıcı Girişi Başarılı!";
	public static string UserAlreadyExists = "Kullanıcı Zaten Mevcut!";
	public static string UserRegistered = "Kullanıcı Başarıyla Kaydedildi!";
	#endregion

	public static string AccessTokenCreated = "Access Token Başarıyla Oluşturuldu!";

}
