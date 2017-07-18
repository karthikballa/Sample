﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShopping.Models.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class OnlineShoppingEntities2 : DbContext
    {
        public OnlineShoppingEntities2()
            : base("name=OnlineShoppingEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Brands> tbl_Brands { get; set; }
        public virtual DbSet<tbl_Categories> tbl_Categories { get; set; }
        public virtual DbSet<tbl_Item> tbl_Item { get; set; }
        public virtual DbSet<tbl_Order> tbl_Order { get; set; }
        public virtual DbSet<tbl_CardDetails> tbl_CardDetails { get; set; }
        public virtual DbSet<tbl_Kart> tbl_Kart { get; set; }
        public virtual DbSet<tbl_City> tbl_City { get; set; }
        public virtual DbSet<tbl_Countrys> tbl_Countrys { get; set; }
        public virtual DbSet<tbl_State> tbl_State { get; set; }
        public virtual DbSet<tbl_User_Registration> tbl_User_Registration { get; set; }
    
        public virtual int Sp_Brands_Delete(Nullable<int> brandID)
        {
            var brandIDParameter = brandID.HasValue ?
                new ObjectParameter("BrandID", brandID) :
                new ObjectParameter("BrandID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_Brands_Delete", brandIDParameter);
        }
    
        public virtual ObjectResult<Sp_Brands_Display_Result> Sp_Brands_Display(Nullable<int> brandID)
        {
            var brandIDParameter = brandID.HasValue ?
                new ObjectParameter("BrandID", brandID) :
                new ObjectParameter("BrandID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Brands_Display_Result>("Sp_Brands_Display", brandIDParameter);
        }
    
        public virtual int Sp_Brands_insert(Nullable<int> categoriesID, string brandName, string brandimage)
        {
            var categoriesIDParameter = categoriesID.HasValue ?
                new ObjectParameter("CategoriesID", categoriesID) :
                new ObjectParameter("CategoriesID", typeof(int));
    
            var brandNameParameter = brandName != null ?
                new ObjectParameter("BrandName", brandName) :
                new ObjectParameter("BrandName", typeof(string));
    
            var brandimageParameter = brandimage != null ?
                new ObjectParameter("Brandimage", brandimage) :
                new ObjectParameter("Brandimage", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_Brands_insert", categoriesIDParameter, brandNameParameter, brandimageParameter);
        }
    
        public virtual int Sp_Brands_update(Nullable<int> brandID, Nullable<int> categoriesID, string brandName, string brandimage)
        {
            var brandIDParameter = brandID.HasValue ?
                new ObjectParameter("BrandID", brandID) :
                new ObjectParameter("BrandID", typeof(int));
    
            var categoriesIDParameter = categoriesID.HasValue ?
                new ObjectParameter("CategoriesID", categoriesID) :
                new ObjectParameter("CategoriesID", typeof(int));
    
            var brandNameParameter = brandName != null ?
                new ObjectParameter("BrandName", brandName) :
                new ObjectParameter("BrandName", typeof(string));
    
            var brandimageParameter = brandimage != null ?
                new ObjectParameter("Brandimage", brandimage) :
                new ObjectParameter("Brandimage", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_Brands_update", brandIDParameter, categoriesIDParameter, brandNameParameter, brandimageParameter);
        }
    
        public virtual int Sp_Categories_Delete(Nullable<int> categoriesID)
        {
            var categoriesIDParameter = categoriesID.HasValue ?
                new ObjectParameter("CategoriesID", categoriesID) :
                new ObjectParameter("CategoriesID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_Categories_Delete", categoriesIDParameter);
        }
    
        public virtual ObjectResult<Sp_Categories_Display_Result> Sp_Categories_Display(Nullable<int> categoriesID)
        {
            var categoriesIDParameter = categoriesID.HasValue ?
                new ObjectParameter("CategoriesID", categoriesID) :
                new ObjectParameter("CategoriesID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Categories_Display_Result>("Sp_Categories_Display", categoriesIDParameter);
        }
    
        public virtual int Sp_Categories_insert(string categoriesName, string categoriesimage)
        {
            var categoriesNameParameter = categoriesName != null ?
                new ObjectParameter("CategoriesName", categoriesName) :
                new ObjectParameter("CategoriesName", typeof(string));
    
            var categoriesimageParameter = categoriesimage != null ?
                new ObjectParameter("Categoriesimage", categoriesimage) :
                new ObjectParameter("Categoriesimage", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_Categories_insert", categoriesNameParameter, categoriesimageParameter);
        }
    
        public virtual int Sp_Categories_update(Nullable<int> categoriesID, string categoriesName, string categoriesimage)
        {
            var categoriesIDParameter = categoriesID.HasValue ?
                new ObjectParameter("CategoriesID", categoriesID) :
                new ObjectParameter("CategoriesID", typeof(int));
    
            var categoriesNameParameter = categoriesName != null ?
                new ObjectParameter("CategoriesName", categoriesName) :
                new ObjectParameter("CategoriesName", typeof(string));
    
            var categoriesimageParameter = categoriesimage != null ?
                new ObjectParameter("Categoriesimage", categoriesimage) :
                new ObjectParameter("Categoriesimage", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_Categories_update", categoriesIDParameter, categoriesNameParameter, categoriesimageParameter);
        }
    
        public virtual int Sp_Item_Delete(Nullable<int> itemID)
        {
            var itemIDParameter = itemID.HasValue ?
                new ObjectParameter("ItemID", itemID) :
                new ObjectParameter("ItemID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_Item_Delete", itemIDParameter);
        }
    
        public virtual ObjectResult<Sp_Item_Display_Result> Sp_Item_Display(Nullable<int> itemID)
        {
            var itemIDParameter = itemID.HasValue ?
                new ObjectParameter("ItemID", itemID) :
                new ObjectParameter("ItemID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Item_Display_Result>("Sp_Item_Display", itemIDParameter);
        }
    
        public virtual int Sp_Item_insert(Nullable<int> brandID, string itemName, string itemimage)
        {
            var brandIDParameter = brandID.HasValue ?
                new ObjectParameter("BrandID", brandID) :
                new ObjectParameter("BrandID", typeof(int));
    
            var itemNameParameter = itemName != null ?
                new ObjectParameter("ItemName", itemName) :
                new ObjectParameter("ItemName", typeof(string));
    
            var itemimageParameter = itemimage != null ?
                new ObjectParameter("Itemimage", itemimage) :
                new ObjectParameter("Itemimage", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_Item_insert", brandIDParameter, itemNameParameter, itemimageParameter);
        }
    
        public virtual int Sp_Item_update(Nullable<int> itemID, Nullable<int> brandID, string itemName, string itemimage)
        {
            var itemIDParameter = itemID.HasValue ?
                new ObjectParameter("ItemID", itemID) :
                new ObjectParameter("ItemID", typeof(int));
    
            var brandIDParameter = brandID.HasValue ?
                new ObjectParameter("BrandID", brandID) :
                new ObjectParameter("BrandID", typeof(int));
    
            var itemNameParameter = itemName != null ?
                new ObjectParameter("ItemName", itemName) :
                new ObjectParameter("ItemName", typeof(string));
    
            var itemimageParameter = itemimage != null ?
                new ObjectParameter("Itemimage", itemimage) :
                new ObjectParameter("Itemimage", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_Item_update", itemIDParameter, brandIDParameter, itemNameParameter, itemimageParameter);
        }
    
        public virtual ObjectResult<Sp_Item_Details_Result> Sp_Item_Details()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Item_Details_Result>("Sp_Item_Details");
        }
    
        public virtual ObjectResult<Sp_categories_Details_Result> Sp_categories_Details()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_categories_Details_Result>("Sp_categories_Details");
        }
    
        public virtual ObjectResult<Sp_Brands_Details_Result> Sp_Brands_Details()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Brands_Details_Result>("Sp_Brands_Details");
        }
    
        public virtual int Sp_insert_order(Nullable<int> itemID, string orderDescription, string orderImage, Nullable<int> price, string quality)
        {
            var itemIDParameter = itemID.HasValue ?
                new ObjectParameter("ItemID", itemID) :
                new ObjectParameter("ItemID", typeof(int));
    
            var orderDescriptionParameter = orderDescription != null ?
                new ObjectParameter("OrderDescription", orderDescription) :
                new ObjectParameter("OrderDescription", typeof(string));
    
            var orderImageParameter = orderImage != null ?
                new ObjectParameter("OrderImage", orderImage) :
                new ObjectParameter("OrderImage", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(int));
    
            var qualityParameter = quality != null ?
                new ObjectParameter("Quality", quality) :
                new ObjectParameter("Quality", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_insert_order", itemIDParameter, orderDescriptionParameter, orderImageParameter, priceParameter, qualityParameter);
        }
    
        public virtual int Sp_order_Delete(Nullable<int> orderID)
        {
            var orderIDParameter = orderID.HasValue ?
                new ObjectParameter("OrderID", orderID) :
                new ObjectParameter("OrderID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_order_Delete", orderIDParameter);
        }
    
        public virtual ObjectResult<Sp_order_Details_Result> Sp_order_Details()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_order_Details_Result>("Sp_order_Details");
        }
    
        public virtual ObjectResult<Sp_order_Display_Result> Sp_order_Display(Nullable<int> orderID)
        {
            var orderIDParameter = orderID.HasValue ?
                new ObjectParameter("OrderID", orderID) :
                new ObjectParameter("OrderID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_order_Display_Result>("Sp_order_Display", orderIDParameter);
        }
    
        public virtual int Sp_order_Update(Nullable<int> orderID, Nullable<int> itemID, string orderDescription, string orderImage, Nullable<int> price, string quality)
        {
            var orderIDParameter = orderID.HasValue ?
                new ObjectParameter("OrderID", orderID) :
                new ObjectParameter("OrderID", typeof(int));
    
            var itemIDParameter = itemID.HasValue ?
                new ObjectParameter("ItemID", itemID) :
                new ObjectParameter("ItemID", typeof(int));
    
            var orderDescriptionParameter = orderDescription != null ?
                new ObjectParameter("OrderDescription", orderDescription) :
                new ObjectParameter("OrderDescription", typeof(string));
    
            var orderImageParameter = orderImage != null ?
                new ObjectParameter("OrderImage", orderImage) :
                new ObjectParameter("OrderImage", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(int));
    
            var qualityParameter = quality != null ?
                new ObjectParameter("Quality", quality) :
                new ObjectParameter("Quality", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_order_Update", orderIDParameter, itemIDParameter, orderDescriptionParameter, orderImageParameter, priceParameter, qualityParameter);
        }
    
        public virtual int Sp_order_insert(Nullable<int> itemID, string orderDescription, string orderImage, Nullable<int> price, string quality)
        {
            var itemIDParameter = itemID.HasValue ?
                new ObjectParameter("ItemID", itemID) :
                new ObjectParameter("ItemID", typeof(int));
    
            var orderDescriptionParameter = orderDescription != null ?
                new ObjectParameter("OrderDescription", orderDescription) :
                new ObjectParameter("OrderDescription", typeof(string));
    
            var orderImageParameter = orderImage != null ?
                new ObjectParameter("OrderImage", orderImage) :
                new ObjectParameter("OrderImage", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(int));
    
            var qualityParameter = quality != null ?
                new ObjectParameter("Quality", quality) :
                new ObjectParameter("Quality", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_order_insert", itemIDParameter, orderDescriptionParameter, orderImageParameter, priceParameter, qualityParameter);
        }
    
        public virtual ObjectResult<Sp_UBrands_Details_Result> Sp_UBrands_Details(Nullable<int> brandId)
        {
            var brandIdParameter = brandId.HasValue ?
                new ObjectParameter("brandId", brandId) :
                new ObjectParameter("brandId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_UBrands_Details_Result>("Sp_UBrands_Details", brandIdParameter);
        }
    
        public virtual ObjectResult<Sp_UItem_Details_Result> Sp_UItem_Details(Nullable<int> brandID)
        {
            var brandIDParameter = brandID.HasValue ?
                new ObjectParameter("BrandID", brandID) :
                new ObjectParameter("BrandID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_UItem_Details_Result>("Sp_UItem_Details", brandIDParameter);
        }
    
        public virtual ObjectResult<Sp_Uorder_Details_Result> Sp_Uorder_Details(Nullable<int> itemID)
        {
            var itemIDParameter = itemID.HasValue ?
                new ObjectParameter("ItemID", itemID) :
                new ObjectParameter("ItemID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Uorder_Details_Result>("Sp_Uorder_Details", itemIDParameter);
        }
    
        public virtual int Sp_CardDetails_Insert(string loginID, Nullable<int> orderID, string type, string cardNumber, string cardName, string expirydate, string cVV)
        {
            var loginIDParameter = loginID != null ?
                new ObjectParameter("LoginID", loginID) :
                new ObjectParameter("LoginID", typeof(string));
    
            var orderIDParameter = orderID.HasValue ?
                new ObjectParameter("OrderID", orderID) :
                new ObjectParameter("OrderID", typeof(int));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            var cardNumberParameter = cardNumber != null ?
                new ObjectParameter("CardNumber", cardNumber) :
                new ObjectParameter("CardNumber", typeof(string));
    
            var cardNameParameter = cardName != null ?
                new ObjectParameter("CardName", cardName) :
                new ObjectParameter("CardName", typeof(string));
    
            var expirydateParameter = expirydate != null ?
                new ObjectParameter("Expirydate", expirydate) :
                new ObjectParameter("Expirydate", typeof(string));
    
            var cVVParameter = cVV != null ?
                new ObjectParameter("CVV", cVV) :
                new ObjectParameter("CVV", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_CardDetails_Insert", loginIDParameter, orderIDParameter, typeParameter, cardNumberParameter, cardNameParameter, expirydateParameter, cVVParameter);
        }
    
        public virtual ObjectResult<Sp_CardDetails_Details_Result> Sp_CardDetails_Details()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_CardDetails_Details_Result>("Sp_CardDetails_Details");
        }
    
        public virtual int Sp_Kart_insert(Nullable<int> orderID, Nullable<int> userID)
        {
            var orderIDParameter = orderID.HasValue ?
                new ObjectParameter("OrderID", orderID) :
                new ObjectParameter("OrderID", typeof(int));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_Kart_insert", orderIDParameter, userIDParameter);
        }
    
        public virtual ObjectResult<Sp_Kart_Details_Result> Sp_Kart_Details()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Kart_Details_Result>("Sp_Kart_Details");
        }
    
        public virtual int Sp_Userregistration_Insert(string firstName, string lastName, string middleName, string emailId, string password, string gender, string mobileNumber, string countryName, string stateName, string cityName, string address1, string address2, Nullable<bool> isActive)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var middleNameParameter = middleName != null ?
                new ObjectParameter("MiddleName", middleName) :
                new ObjectParameter("MiddleName", typeof(string));
    
            var emailIdParameter = emailId != null ?
                new ObjectParameter("EmailId", emailId) :
                new ObjectParameter("EmailId", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var mobileNumberParameter = mobileNumber != null ?
                new ObjectParameter("MobileNumber", mobileNumber) :
                new ObjectParameter("MobileNumber", typeof(string));
    
            var countryNameParameter = countryName != null ?
                new ObjectParameter("CountryName", countryName) :
                new ObjectParameter("CountryName", typeof(string));
    
            var stateNameParameter = stateName != null ?
                new ObjectParameter("StateName", stateName) :
                new ObjectParameter("StateName", typeof(string));
    
            var cityNameParameter = cityName != null ?
                new ObjectParameter("CityName", cityName) :
                new ObjectParameter("CityName", typeof(string));
    
            var address1Parameter = address1 != null ?
                new ObjectParameter("Address1", address1) :
                new ObjectParameter("Address1", typeof(string));
    
            var address2Parameter = address2 != null ?
                new ObjectParameter("Address2", address2) :
                new ObjectParameter("Address2", typeof(string));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_Userregistration_Insert", firstNameParameter, lastNameParameter, middleNameParameter, emailIdParameter, passwordParameter, genderParameter, mobileNumberParameter, countryNameParameter, stateNameParameter, cityNameParameter, address1Parameter, address2Parameter, isActiveParameter);
        }
    
        public virtual int Sp_Userregistration_Update(Nullable<int> userID, string firstName, string lastName, string middleName, string emailId, string password, string gender, string mobileNumber, string countryName, string stateName, string cityName, string address1, string address2, Nullable<bool> isActive)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var middleNameParameter = middleName != null ?
                new ObjectParameter("MiddleName", middleName) :
                new ObjectParameter("MiddleName", typeof(string));
    
            var emailIdParameter = emailId != null ?
                new ObjectParameter("EmailId", emailId) :
                new ObjectParameter("EmailId", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var mobileNumberParameter = mobileNumber != null ?
                new ObjectParameter("MobileNumber", mobileNumber) :
                new ObjectParameter("MobileNumber", typeof(string));
    
            var countryNameParameter = countryName != null ?
                new ObjectParameter("CountryName", countryName) :
                new ObjectParameter("CountryName", typeof(string));
    
            var stateNameParameter = stateName != null ?
                new ObjectParameter("StateName", stateName) :
                new ObjectParameter("StateName", typeof(string));
    
            var cityNameParameter = cityName != null ?
                new ObjectParameter("CityName", cityName) :
                new ObjectParameter("CityName", typeof(string));
    
            var address1Parameter = address1 != null ?
                new ObjectParameter("Address1", address1) :
                new ObjectParameter("Address1", typeof(string));
    
            var address2Parameter = address2 != null ?
                new ObjectParameter("Address2", address2) :
                new ObjectParameter("Address2", typeof(string));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_Userregistration_Update", userIDParameter, firstNameParameter, lastNameParameter, middleNameParameter, emailIdParameter, passwordParameter, genderParameter, mobileNumberParameter, countryNameParameter, stateNameParameter, cityNameParameter, address1Parameter, address2Parameter, isActiveParameter);
        }
    
        public virtual ObjectResult<Sp_UserRegistration_Details_Result> Sp_UserRegistration_Details()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_UserRegistration_Details_Result>("Sp_UserRegistration_Details");
        }
    
        public virtual ObjectResult<Sp_UserRegistration_Display_Result> Sp_UserRegistration_Display(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_UserRegistration_Display_Result>("Sp_UserRegistration_Display", userIDParameter);
        }
    
        public virtual int Sp_UserRegistraion_Delete(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_UserRegistraion_Delete", userIDParameter);
        }
    
        public virtual ObjectResult<Sp_UCtgryBrand_Details_Result> Sp_UCtgryBrand_Details(Nullable<int> categoriesID)
        {
            var categoriesIDParameter = categoriesID.HasValue ?
                new ObjectParameter("CategoriesID", categoriesID) :
                new ObjectParameter("CategoriesID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_UCtgryBrand_Details_Result>("Sp_UCtgryBrand_Details", categoriesIDParameter);
        }
    
        public virtual ObjectResult<Sp_BItem_Details_Result> Sp_BItem_Details(Nullable<int> brandID)
        {
            var brandIDParameter = brandID.HasValue ?
                new ObjectParameter("BrandID", brandID) :
                new ObjectParameter("BrandID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_BItem_Details_Result>("Sp_BItem_Details", brandIDParameter);
        }
    
        public virtual ObjectResult<Sp_Kart_Createtable_Result> Sp_Kart_Createtable(Nullable<int> kartID, Nullable<int> orderID, Nullable<int> userID)
        {
            var kartIDParameter = kartID.HasValue ?
                new ObjectParameter("KartID", kartID) :
                new ObjectParameter("KartID", typeof(int));
    
            var orderIDParameter = orderID.HasValue ?
                new ObjectParameter("OrderID", orderID) :
                new ObjectParameter("OrderID", typeof(int));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Kart_Createtable_Result>("Sp_Kart_Createtable", kartIDParameter, orderIDParameter, userIDParameter);
        }
    }
}
