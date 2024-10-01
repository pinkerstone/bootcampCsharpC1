// See https://aka.ms/new-console-template for more information

using CodigoClase12;

List<INotificacion> notificaciones = new List<INotificacion>();

notificaciones.Add(new Email());
notificaciones.Add(new Sms());

foreach (var item in notificaciones)
{
    item.Enviar();
}

Console.ReadKey();