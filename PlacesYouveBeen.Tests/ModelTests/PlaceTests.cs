using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesYouveBeen.Models;
using System;

namespace PlacesYouveBeen.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceConstructor_CreatesInstanceofPlace_Place()
    {
      Place newPlace = new Place("test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      string cityName = "Severn";
      Place newPlace = new Place(cityName);
      string result = newPlace.CityName;
      Assert.AreEqual(cityName, result);
    }

    [TestMethod]
    public void SetCityName_SetCityName_String()
    {
      string cityName = "Severn";
      Place newPlace = new Place(cityName);

      string updatedCityName = "Bend";
      newPlace.CityName = updatedCityName;
      string result = newPlace.CityName;
      Assert.AreEqual(updatedCityName, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_PlaceList()
    {
      List<Place> newList = new List<Place> { };
      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsPlaces_PlaceList()
    {
      string cityName01 = "Severn";
      string cityName02 = "Bend";
      Place newPlace1 = new Place(cityName01);
      Place newPlace2 = new Place(cityName02);
      List<Place> newList = new List<Place> { newPlace1, newPlace2 };

      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_PlacesInstantiateWithAnIdAndGetterReturns_Int()
    {
      string cityName = "Severn";
      Place newPlace = new Place(cityName);
      int result = newPlace.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectPlace_Place()
    {
      string cityName01 = "Severn";
      string cityName02 = "Bend";
      Place newCity1 = new Place(cityName01);
      Place newCity2 = new Place(cityName02);

      Place result = Place.Find(2);
      Assert.AreEqual(newCity2, result);
    }
  }
}