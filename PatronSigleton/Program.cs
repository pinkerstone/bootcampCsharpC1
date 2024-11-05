// See https://aka.ms/new-console-template for more information

using PatronSigleton;

void Mensaje1()
{
    Email email = Email.Instance;
    email.Mensaje = "Hola";
    email.Send();
}
void Mensaje2()
{
    Email email = Email.Instance;
    email.Mensaje = "Donde";
    email.Send();
}
void Mensaje3()
{
    Email email = Email.Instance;
    email.Mensaje = "Estas";
    email.Send();
}

Mensaje1();
Mensaje2();
Mensaje3();

Logger.Mensaje = "Hola";
Logger.Send();
Logger.Send();
Logger.Send();