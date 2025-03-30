using System;
using System.Numerics;

class Order 
{
    private string _customer = 
    private List<Product> _productList = new List<Product>();
    
    public double TotalCostOfOrder()
    {
        double totalCost = 0;
        foreach(Product lineItemInOrder in _productList)
        {
            totalCost = totalCost + lineItemInOrder.GetProductTotalCost();
        }
        return totalCost;
    }
    public string PackingLabel()
    {
        return ;
    }
    public string ShippingLabel()
    {
        return "";
    }
}