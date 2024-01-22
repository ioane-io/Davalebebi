namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Product product1 = new Product("phone", 500, ProductCategory.Electronics, 10, 30);
                DiscountedProduct discountedProduct1 = new DiscountedProduct("Discounted book one", 20, ProductCategory.Books, 10, 20);
                Inventory inventory = new Inventory();
                inventory.DictionaryAddItem("phone", product1);
                inventory.DictionaryAddItem("book one", discountedProduct1);
                Item returnedItem = inventory.GetItem("phone");
                Console.WriteLine(returnedItem.GetProductInfo());
                decimal totalPrice = inventory.CalculateTotalPrice();
                Console.WriteLine($" Total Price all items : ${totalPrice}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}