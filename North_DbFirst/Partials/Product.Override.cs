﻿namespace North_DbFirst.Models
{
    public partial class Product
	{
        public override string ToString()
        {
            return $"{ProductName.ToUpper()} - {UnitPrice:c2}";
        }
	}
}