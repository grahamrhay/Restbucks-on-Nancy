﻿namespace RestBucks.Resources.Products
{
  using System.Xml.Serialization;

  [XmlRoot("item")]
  public class ItemRepresentation
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
  }
}