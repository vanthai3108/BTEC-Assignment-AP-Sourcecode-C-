using System;

namespace AbstractFactory
{
	abstract class Address
	{
		public abstract void Show();
	}

	class USAddress : Address
	{
		public override void Show()
		{
			Console.WriteLine("This is USA Address");
		}
	}

	class VNAddress : Address
	{
		public override void Show()
		{
			Console.WriteLine("This is VN address");
		}
	}

	abstract class Phone
	{
		public abstract void Show();
	}

	class USPhone : Phone
	{
		public override void Show()
		{
			Console.WriteLine("This is USA Phone");
		}
	}

	class VNPhone : Phone
	{
		public override void Show()
		{
			Console.WriteLine("This is VN phone");
		}
	}

	abstract class Factory
	{
		virtual public Address createAddress()
		{
			return null;
		}
		virtual public Phone createPhone()
		{
			return null;
		}
	}

	class USFactory : Factory
	{
		public override Address createAddress()
		{
			return new USAddress();
		}
		public override Phone createPhone()
		{
			return new USPhone();
		}
	}

	class VNFactory : Factory
	{
		public override Address createAddress()
		{
			return new VNAddress();
		}
		public override Phone createPhone()
		{
			return new VNPhone();
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("-----Create Object by VNFactory-----");
			Factory factory_vn = new VNFactory();
			Address address_vn = factory_vn.createAddress();
			Phone phone_vn = factory_vn.createPhone();
			address_vn.Show();
			phone_vn.Show();

			Console.WriteLine("-----Create Object by USFactory-----");
			Factory factory_us = new USFactory();
			Address address_us = factory_us.createAddress();
			Phone phone_us = factory_us.createPhone();
			address_us.Show();
			phone_us.Show();
		}
	}
}
