﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllReady.Models
{
  public class Location
  {
    public int Id { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public PostalCodeGeo PostalCode { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Country { get; set; } = "USA";
  }
}