using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone("(61) 98764-1232", "15 Pro Max", "356303486840547", 128);
Nokia nokia = new Nokia("(61) 98544-2562", "Sansung Galaxy S24", "356303486840547", 512);

iphone.Ligar();
iphone.ReceberLigacao();
nokia.Ligar();
nokia.ReceberLigacao();

iphone.InstalarAplicativo("Calculadora");
nokia.InstalarAplicativo("Câmera");
