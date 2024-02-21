using System;

class Program : Delivery
{
	public static void Main(string[] args)
	{
		Product product = new Product();
		PickPointDelivery delivery = new PickPointDelivery();

		product.InfoBuyer();
		delivery.DeliveryToPickPoint();

		Console.WriteLine(product.Name);
	}
}
abstract class Delivery
{ 
	public string Address;
	public string Name;
	public int Product;

	public string[] Products = new string[4];

	public void InfoBuyer()
	{
		Product product = new Product();

		Console.WriteLine("������� ��� ����������");
		Name = Console.ReadLine();

		Console.WriteLine("������� ����� ��������");
		Address = Console.ReadLine();

		Console.WriteLine("�������� �����(������� ����� �������)");
		for (int i = 1; i < Products.Length; i++)
			Console.WriteLine(Products[i]);
		Product = Convert.ToInt32(Console.ReadLine());
	}
}

class HomeDelivery : Delivery
{

}

class PickPointDelivery : Delivery
{
	public void DeliveryToPickPoint()
	{
		Console.WriteLine($"��� ����� ������, ��������: {Products[Product]} \n �� ���������� ������ ������ � ������: {Address}\n �� ���: {Name}");
	}
}

class ShopDelivery : Delivery
{

}

class Order<TDelivery,
TStruct> where TDelivery : Delivery
{
	public TDelivery Delivery;
	public int Number;
	public string Description;

	public void DisplayAddress()
	{
		Console.WriteLine(Delivery.Address);
	}

}
class Product : Delivery
{
}