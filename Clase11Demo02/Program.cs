// See https://aka.ms/new-console-template for more information

using Clase11Demo02;

void EjemploClaseAbstracta()
{
    Vehiculo bicicleta1 = new Bicicleta();

    bicicleta1.Encender();
    bicicleta1.Acelerar(5);
}

//Motocicleta motoCicleta = new Motocicleta();
//motoCicleta.Acelerar(5);
//motoCicleta.Arrancar();

List<IMotor> motores = new List<IMotor>();

motores.Add(new MotorGas());
motores.Add(new MotorElectrico());  

foreach (IMotor motor in motores)
{
    motor.Arrancar();
    motor.Apagar();
}

Console.ReadKey();