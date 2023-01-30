using System;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia (numero: "22335588", modelo: "NK684", imei: "1928376455", memoria: 4);
nokia.Ligar ();
nokia.InstalarAplicativo ("DIO");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone (numero: "987654321", modelo: "IP456", imei: "784512963", memoria: 120);
iphone.Ligar  ();
iphone.InstalarAplicativo ("Facebook");


