﻿namespace RestBucks.Resources.Orders.Representations
{
  using System.Collections.Generic;
  using System.Linq;
  using System.Xml.Serialization;

  using Domain;

  [XmlRoot(ElementName = "order", Namespace = "http://restbuckson.net")]
  public class OrderRepresentation : RepresentationBase
  {
    public OrderRepresentation()
    {
      Items = new List<OrderItemRepresentation>();
    }
    
    public OrderRepresentation(Order order)
    {
      Location = order.Location;
      Cost = order.Total;
      Items = order.Items.Select(item => new OrderItemRepresentation(item)).ToList();
      Status = order.Status;
    }

    [XmlElement(ElementName = "location")]
    public Location Location { get; set; }

    [XmlElement(ElementName = "cost")]
    public decimal Cost { get; set; }

    [XmlArray(ElementName = "items"), XmlArrayItem(ElementName = "item")]
    public List<OrderItemRepresentation> Items { get; set; }

    [XmlElement(ElementName = "status")]
    public OrderStatus Status { get; set; }
  }
}