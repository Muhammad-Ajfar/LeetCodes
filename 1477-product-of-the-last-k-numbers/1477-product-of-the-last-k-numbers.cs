public class ProductOfNumbers {
    private List<int> prefixProducts;
    
    public ProductOfNumbers() {
        prefixProducts = new List<int>();
        prefixProducts.Add(1);
    }
    
    public void Add(int num) {
        if (num == 0) {

            prefixProducts = new List<int>();
            prefixProducts.Add(1);
        } else {
            int lastProduct = prefixProducts[prefixProducts.Count - 1];
            prefixProducts.Add(lastProduct * num);
        }
    }
    
    public int GetProduct(int k) {
        int n = prefixProducts.Count;
        if (k >= n) {
            return 0;
        }
        return prefixProducts[n - 1] / prefixProducts[n - 1 - k];
    }
}
