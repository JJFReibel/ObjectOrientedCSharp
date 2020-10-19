/*
MIT License

Copyright (c) 2020 Jean-Jacques François Reibel

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;

class Car {
  public int wheels;
  public int doors;
  public int cylinders;
  public Car(int wheels, int doors, int cylinders) {
    this.wheels = wheels;
    this.doors = doors;
    this.cylinders = cylinders;
  }

  public void addWheels(int wheels) {
    this.wheels += wheels;
  }

  public void addDoors(int doors) {
    this.doors += doors;
  }

  public void addCylinders(int cylinders) {
    this.cylinders += cylinders;
  }

  public void deleteWheels(int wheels) {
    this.wheels -= wheels;
  }

  public void deleteDoors(int doors) {
    this.doors -= doors;
  }

  public void deleteCylinders(int cylinders) {
    this.cylinders -= cylinders;
  }
}

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Creating car.");
    Car subaru = new Car(4, 4, 4);
    Console.WriteLine("Wheels check: " + subaru.wheels);
    Console.WriteLine("Doors check: " + subaru.doors);
    Console.WriteLine("Cylinders check: " + subaru.cylinders);
    Console.WriteLine("");
    Console.WriteLine("Adding wheel directly to car object.");
    subaru.wheels = 5;
    Console.WriteLine("Wheels check: " + subaru.wheels);
    Console.WriteLine("Doors check: " + subaru.doors);
    Console.WriteLine("Cylinders check: " + subaru.cylinders);
    Console.WriteLine("");
    Console.WriteLine("Removing wheel using class method.");
    subaru.deleteWheels(1);
    Console.WriteLine("Wheels check: " + subaru.wheels);
    Console.WriteLine("Doors check: " + subaru.doors);
    Console.WriteLine("Cylinders check: " + subaru.cylinders);
    Console.WriteLine("");
  }
}