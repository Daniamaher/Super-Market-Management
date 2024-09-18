//using AspNetCore;






using System.Collections.Generic;
using System.Linq;

namespace supermarketsys.Models
{
    public class CategoriesRepository
    {
        private static List<Category> categories = new List<Category>()
        {
            new Category { CategoryId = 1, Name = "Beverage", Description = "Beverage" },
            new Category { CategoryId = 2, Name = "Bakery", Description = "Bakery" },
            new Category { CategoryId = 3, Name = "Meat", Description = "Meat" },
        };

        public static List<Category> GetCategories() => categories;

        public static void AddCategory(Category category)
        {
            var maxId = categories.Max(x => x.CategoryId);
            category.CategoryId = maxId + 1;

            categories.Add(category);
        }

        public static Category? GetCategoryById(int categoryId)
        {
            var category = categories.FirstOrDefault(x => x.CategoryId == categoryId);
            if (category != null)
            {
                return new Category
                {
                    CategoryId = category.CategoryId,
                    Name = category.Name,
                    Description = category.Description
                };
            }
            return null; 
        }



        public static void UpdateCategory(int categoryId,Category category)
        {
            if (categoryId != category.CategoryId) return;

            var categoryToUpdate = categories.FirstOrDefault(x => x.CategoryId == categoryId);

            if (categoryToUpdate != null)
            {
                //categoryToUpdate.CategoryId = categoryId;
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }

        }





        public static void DeleteCategory (int categoryId)
        {
            var category = categories.FirstOrDefault(x => x.CategoryId == categoryId);
            if (category != null)
            {
               categories.Remove(category);
            }
        }

        


    }


}
