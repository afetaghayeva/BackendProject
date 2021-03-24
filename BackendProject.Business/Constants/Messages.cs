using System;
using System.Collections.Generic;
using System.Text;
using BackendProject.Entities.Concrete;
using Core.Entity.Concrete;

namespace BackendProject.Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Product name is invalid";
        public static string MaintenanceTime= "System is under maintenance";
        public static string ProductsListed="Products listed";
        public static string ProductCountOfCategoryError="Product count is must less than 10 in a category";
        public static string ProductNameAlreadyExists="Product name already exists";
        public static string CategoryLimitExceeded="New product must not be add";
        public static string AuthorizationDenied="Authorization denied";
        public static string UserRegistered="User registered";
        public static string UserNotFound="User not found";
        public static string PasswordError="Password is incorrect";
        public static string SuccessfulLogin="Successful login";
        public static string UserAlreadyExists="User already exists";
        public static string AccessTokenCreated="Access token created";
    }
}
