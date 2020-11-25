using System;

class MainClass {
  public static void Main (string[] args) {
    Persona Francisco = new Persona();
    Persona Oscar = new Persona();
    Francisco.NOMBRE = "Francisco";
    Francisco.OJOS = "marrones";
    Francisco.ALTURA = 96.3;
    Francisco.PESO = 15;
    Francisco.PROFESION = "Estudiante";
    Francisco.Datos();
    Oscar.NOMBRE = "Oscar";
    Oscar.OJOS = "marrones";
    Oscar.ALTURA = 1.72;
    Oscar.PESO = 78;
    Oscar.PROFESION = "Programador";
    Oscar.Datos();
  }
}

class Persona{
	//propiedades auto- inplementadas
  public string NOMBRE{get;set;}
	public string OJOS{get;set;}
	public double ALTURA{get;set;}
	public int PESO{get;set;}
	public string PROFESION{get;set;}

  public void Datos(){
    if(PESO < 50) Console.WriteLine("{0} tiene ojos color {1}, mide {2}cm, pesa {3}kg y no tiene profesión, es aún un {4}.",
    NOMBRE, OJOS, ALTURA, PESO, PROFESION);
    else Console.WriteLine("{0} tiene ojos color {1}, mide {2}cm, pesa {3}kg y su profesión es {4}.",
    NOMBRE, OJOS, ALTURA, PESO, PROFESION);
  }
}