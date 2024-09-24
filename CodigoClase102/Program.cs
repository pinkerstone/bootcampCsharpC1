// See https://aka.ms/new-console-template for more information


using CodigoClase102;

List<Cuenta> cuentas = new List<Cuenta>();

Cuenta cuentaAhorro = new CuentaAhorro()
{
    NumeroCuenta = "1234",
    Saldo = 0,
    Titular = "Luis"
};

Cuenta cuentaCorriente = new CuentaCorriente()
{
    NumeroCuenta = "5678",
    Saldo = 0,
    Titular = "Jose"
};

cuentaAhorro.Depositar(1000);
cuentaCorriente.Depositar(1000);
cuentaAhorro.Retirar(100);
cuentaCorriente.Retirar(100);

cuentas.Add(cuentaCorriente);
cuentas.Add(cuentaAhorro);

foreach (var item in cuentas)
{
    item.MostrarDetalle();
}



