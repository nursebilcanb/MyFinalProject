using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added";

        public static string ProductNameInvalid = "Product name invalid";

        public static string MaintenanceTime = "System on maintenance";

        public static string ProductsListed = "Products listed";

        public static string ProductCountOfCategoryError = "A category can have max 10 products";

        public static string ProductNameAlreadyExistsError = "This product name already exists";

        public static string CategoryLimitExceeded = "New product can't added because of limit of category exceeded";

        public static string AuthorizationDenied = "You have not any authorization";

        public static string UserRegistered = "Registered";

        public static string UserNotFound = "User not found";

        public static string PasswordError = "Password error";

        public static string AccessTokenCreated = "Token created successfully";

        public static string SuccessfulLogin = "Login successfully";

        public static string UserAlreadyExists = "This user already exists"; 
    }

}
